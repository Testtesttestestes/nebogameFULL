using System;
using System.Collections.Generic;
using Gameplay.Inventory.View.Chest;
using Gameplay.WorldAxis.ColossusInfo.Events;
using Gameplay.WorldAxis.ColossusInfo.Model;
using Gameplay.WorldAxis.ColossusInfo.View;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Common;

namespace Gameplay.WorldAxis.ColossusInfo.Controller
{
	// Token: 0x0200032E RID: 814
	[Token(Token = "0x200032E")]
	public class ColossusTreasuryViewMediator : AbstractViewMediator<ColossusTreasuryModel, ColossusTreasuryEvents, ColossusTreasuryController, ColossusTreasuryView>, IHideableMediator
	{
		// Token: 0x060012A8 RID: 4776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A8")]
		[Address(RVA = "0x64A2", Offset = "0x64A2", VA = "0x64A2")]
		public ColossusTreasuryViewMediator(ColossusTreasuryModel model, ColossusTreasuryEvents events, ColossusTreasuryController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58be4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusTreasuryModel__ColossusTreasuryEvents__ColossusTreasuryController__ColossusTreasuryView__set_View__
		              );
		    DAT_ram_00a58be4 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__set_Events
		              (param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__ResetView
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170002E7 RID: 743
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E7")]
		public override ColossusTreasuryView View
		{
			[Token(Token = "0x60012A9")]
			[Address(RVA = "0x64A3", Offset = "0x64A3", VA = "0x64A3", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170002E8 RID: 744
		// (set) Token: 0x060012AA RID: 4778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E8")]
		public override ColossusTreasuryEvents Events
		{
			[Token(Token = "0x60012AA")]
			[Address(RVA = "0x64A4", Offset = "0x64A4", VA = "0x64A4", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AB")]
		[Address(RVA = "0x64A5", Offset = "0x64A5", VA = "0x64A5")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int param1_00;
		  
		  if (DAT_ram_00a58be7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusTreasuryModel__ColossusTreasuryEvents__ColossusTreasuryController__ColossusTreasuryView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_BuyButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_CreateClanButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_ToTreasuryButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ColossusTreasuryView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58be7 = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar3 + 0x28) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_BuyButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar2,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar3 + 0x2c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_CreateClanButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar2,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar3 + 0x30) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_ToTreasuryButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar2,0);
		  iVar3 = *param1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x148) * 4))
		                    (param1,*(undefined4 *)(iVar3 + 0x14c));
		  Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController___ctor(uVar2,iVar3);
		  Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__BuyButtonClickedEventHandler
		            (param1,iVar3);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x238);
		        goto code_r0x80f86c1c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x80f86c1c:
		  iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  if (*(int *)(iVar3 + 0x10) != 0) {
		    param1_00 = *param1;
		    iVar3 = (**(code **)((ulonglong)*(uint *)(param1_00 + 0x158) * 4))
		                      (param1,*(undefined4 *)(param1_00 + 0x15c));
		    uVar5 = *(undefined4 *)(iVar3 + 0x1c);
		    uVar2 = Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__Select
		                      (param1_00,param1_00);
		    Gameplay_Inventory_View_Chest_InventoryGridView__TabBarOnChangeEvent(uVar5,uVar2,0);
		  }
		  if (*(int *)(*(int *)(param1[2] + 8) + 0x68) == 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (uVar2,2,
		               Method_UI_MonoBehaviourWithStates_ColossusTreasuryView_State__set_CurrentState__);
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		        goto code_r0x80f86d27;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f86d27:
		  iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  iVar3 = *(int *)(*(int *)(iVar3 + 0x10) + 0x20);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar3 == 0) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (uVar2,3,
		               Method_UI_MonoBehaviourWithStates_ColossusTreasuryView_State__set_CurrentState__);
		    return;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar2,1,
		             Method_UI_MonoBehaviourWithStates_ColossusTreasuryView_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AC")]
		[Address(RVA = "0x64A6", Offset = "0x64A6", VA = "0x64A6")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__SetupView
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58be8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58be8 = '\x01';
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
		        goto code_r0x80f87bde;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f87bde:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_ClansManager__GetFractionByCult(param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AD")]
		[Address(RVA = "0x64A7", Offset = "0x64A7", VA = "0x64A7")]
		private void ToTreasuryButtonClickedEventHandler()
		{
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AE")]
		[Address(RVA = "0x64A8", Offset = "0x64A8", VA = "0x64A8")]
		private void UpdateInventoryView()
		{
		/* --- GHIDRA: UpdateInventoryView ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__UpdateInventoryView
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58be9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58be9 = '\x01';
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
		        goto code_r0x80f87cda;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f87cda:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_ClansManager__HandleControllerInitEvent(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AF")]
		[Address(RVA = "0x64A9", Offset = "0x64A9", VA = "0x64A9")]
		private void CreateClanButtonClickedEventHandler()
		{
		/* --- GHIDRA: CreateClanButtonClickedEventHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__CreateClanButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController__GetTreasuryOptionsResultHandler
		            (param1_00,param1[6],param1);
		  return;
		}
		*/

		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B0")]
		[Address(RVA = "0x64AA", Offset = "0x64AA", VA = "0x64AA")]
		private void BuyButtonClickedEventHandler()
		{
		/* --- GHIDRA: BuyButtonClickedEventHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__BuyButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a58bea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusTreasuryModel__ColossusTreasuryEvents__ColossusTreasuryController__ColossusTreasuryView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a58bea = '\x01';
		  }
		  if (*(int *)(param1[2] + 0x10) != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar2 + 0x24);
		    uVar1 = 0;
		    param1_01 = *(int **)(param1[2] + 0x10);
		    iVar2 = *param1_01;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Data_Balance_IBalanceSource_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x80f86ede;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Core_Data_Balance_IBalanceSource_TypeInfo,2);
		code_r0x80f86ede:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar4 = Core_Money_Money__op_Explicit(uVar4,0);
		    UI_Price_Price__SetColor(param1_00,0,uVar4,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B1")]
		[Address(RVA = "0x64AB", Offset = "0x64AB", VA = "0x64AB")]
		private void UpdateBalance()
		{
		/* --- GHIDRA: UpdateBalance ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__UpdateBalance
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x1c);
		  param2_00 = Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__Select
		                        (param1,param1);
		  Gameplay_Inventory_View_Chest_InventoryGridView__TabBarOnChangeEvent(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B2")]
		[Address(RVA = "0x64AC", Offset = "0x64AC", VA = "0x64AC")]
		private void InventoryChangedEventHandler()
		{
		/* --- GHIDRA: InventoryChangedEventHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__InventoryChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58beb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusTreasuryModel__ColossusTreasuryEvents__ColossusTreasuryController__ColossusTreasuryView__get_Model__
		              );
		    DAT_ram_00a58beb = '\x01';
		  }
		  if (DAT_ram_00a58bec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusTreasuryModel__ColossusTreasuryEvents__ColossusTreasuryController__ColossusTreasuryView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TreasuryOptionListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_ListElementClickedEventHandler__
		              );
		    DAT_ram_00a58bec = '\x01';
		  }
		  iVar3 = *(int *)(param1[2] + 0x14);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    iVar1 = 0;
		    do {
		      iVar4 = *(int *)(iVar3 + iVar1 * 4 + 0x10);
		      uVar2 = unnamed_function_1417(System_Action_TreasuryOptionListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar2,param1,
		                 Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_ListElementClickedEventHandler__
		                 ,0);
		      *(undefined4 *)(iVar4 + 0x18) = uVar2;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  iVar3 = *param1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar3 + 0x15c));
		  Gameplay_WorldAxis_ColossusInfo_View_ColossusTreasuryView__get_ToTreasuryButton
		            (uVar2,*(undefined4 *)(param1[2] + 0x14),iVar3);
		  iVar3 = *(int *)(*(int *)(param1[2] + 0x14) + 0x10);
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (iVar3,1,0);
		  param1[6] = iVar3;
		  return;
		}
		*/

		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B3")]
		[Address(RVA = "0x64AD", Offset = "0x64AD", VA = "0x64AD")]
		private void TreasuryOptionsRequestedEventHandler()
		{
		/* --- GHIDRA: TreasuryOptionsRequestedEventHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__TreasuryOptionsRequestedEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__BuyButtonClickedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B4")]
		[Address(RVA = "0x64AE", Offset = "0x64AE", VA = "0x64AE")]
		private void ClanBalanceChangedEventHandler(ResourceSet balance, ResourceSet delta)
		{
		/* --- GHIDRA: ClanBalanceChangedEventHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__ClanBalanceChangedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a58bec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusTreasuryModel__ColossusTreasuryEvents__ColossusTreasuryController__ColossusTreasuryView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TreasuryOptionListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_ListElementClickedEventHandler__
		              );
		    DAT_ram_00a58bec = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 8) + 0x14);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar3 = *(int *)(iVar2 + iVar1 * 4 + 0x10);
		      param1_00 = unnamed_function_1417(System_Action_TreasuryOptionListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_00,param1,
		                 Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_ListElementClickedEventHandler__
		                 ,0);
		      *(undefined4 *)(iVar3 + 0x18) = param1_00;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B5")]
		[Address(RVA = "0x64AF", Offset = "0x64AF", VA = "0x64AF")]
		private void InjectCallback()
		{
		/* --- GHIDRA: InjectCallback ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__InjectCallback
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58bed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_TreasuryOptionListElement_TreasuryOptionListElementArgs__get_args__
		              );
		    DAT_ram_00a58bed = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		              (*(int *)(param1 + 0x18),0,0);
		  }
		  param1_00 = *(undefined4 *)(param2 + 0x18);
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (param1_00,1,0);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B6")]
		[Address(RVA = "0x64B0", Offset = "0x64B0", VA = "0x64B0")]
		private void ListElementClickedEventHandler(TreasuryOptionListElement element)
		{
		/* --- GHIDRA: ListElementClickedEventHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__ListElementClickedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (param2,1,0);
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/

		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B7")]
		[Address(RVA = "0x64B1", Offset = "0x64B1", VA = "0x64B1")]
		private void Select(TreasuryOptionListElement.TreasuryOptionListElementArgs args)
		{
		/* --- GHIDRA: Select ---
		/* WARNING: Removing unreachable block (ram,0x80f8737a) */
		/* WARNING: Removing unreachable block (ram,0x80f871ea) */
		
		int Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__Select
		              (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  int iVar11;
		  undefined4 uVar12;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58bee == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_Chest_ArtifactCategoryData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__ArtifactCategoryData__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ArtifactCategoryData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ArtikulTypeFilters__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ArtifactCategoryData__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_ArtifactData___get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_ArtifactData___get_Keys__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ArtifactCategoryData__set_Item__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__ArtifactCategoryData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_InventoryMetaFilterData___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_ArtifactData___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_ArtifactData___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_ArtifactData___get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_InventoryMetaFilterData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_ArtifactData___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Sirenix_Utilities_LinqExtensions_AddRange_ArtifactData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactCategoryData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactCategoryData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactCategoryData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator___c__DisplayClass19_0__GetArtikulTypeGroupedData_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator___c__DisplayClass19_0_TypeInfo
		              );
		    DAT_ram_00a58bee = '\x01';
		  }
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_ArtifactCategoryData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_ArtifactCategoryData___ctor__);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar10 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar11 = *piVar10;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0x238);
		        goto code_r0x80f870b1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar10,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x80f870b1:
		  iVar11 = (**(code **)((ulonglong)*puVar3 * 4))(piVar10,puVar3[1]);
		  iVar11 = *(int *)(iVar11 + 0x10);
		  uVar4 = Gameplay_Inventory_Model_InventoryBaseModel___ctor(iVar11,0);
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_uint__ArtifactCategoryData__TypeInfo)
		  ;
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_uint__ArtifactCategoryData___ctor__);
		  uVar5 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (*(undefined4 *)(iVar11 + 0x24),
		                     Method_System_Collections_Generic_Dictionary_uint__List_ArtifactData___get_Keys__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_20,uVar5,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_ArtifactData___GetEnumerator__
		            );
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		code_r0x80f87148:
		  DAT_ram_009d3e38 = 0;
		  iVar6 = import::env::invoke_iii
		                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ad,local_10,
		                     Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_ArtifactData___MoveNext__
		                    );
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80f8767e;
		  }
		  iVar9 = local_20;
		  if (iVar6 == 0) goto code_r0x80f876c7;
		  DAT_ram_009d3e38 = 0;
		  iVar9 = import::env::invoke_ii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                     Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator___c__DisplayClass19_0_TypeInfo
		                    );
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80f8767e;
		  }
		  *(undefined4 *)(iVar9 + 8) = local_8._4_4_;
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::invoke_ii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                     System_Func_InventoryMetaFilterData__bool__TypeInfo);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80f87400:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80f8767e;
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_viiii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar5,iVar9,
		             Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator___c__DisplayClass19_0__GetArtikulTypeGroupedData_b__0__
		             ,0);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80f87400;
		  DAT_ram_009d3e38 = 0;
		  iVar7 = import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x179,uVar4,uVar5,
		                     Method_System_Linq_Enumerable_First_InventoryMetaFilterData___);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80f8767e;
		  }
		  DAT_ram_009d3e38 = 0;
		  iVar8 = import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                     *(undefined4 *)(iVar7 + 0x14),*(undefined4 *)(iVar9 + 8),
		                     Method_System_Collections_Generic_Dictionary_uint__ArtikulTypeFilters__get_Item__
		                    );
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80f8767e;
		  }
		  uVar5 = *(undefined4 *)(iVar8 + 0xc);
		  DAT_ram_009d3e38 = 0;
		  iVar8 = import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,param1_00,uVar5,
		                     Method_System_Collections_Generic_Dictionary_uint__ArtifactCategoryData__ContainsKey__
		                    );
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80f8767e;
		  }
		  if (iVar8 != 0) {
		code_r0x80f87567:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,param1_00,uVar5,
		                       Method_System_Collections_Generic_Dictionary_uint__ArtifactCategoryData__get_Item__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f8767e;
		    }
		    uVar12 = *(undefined4 *)(iVar7 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                       *(undefined4 *)(iVar11 + 0x24),*(undefined4 *)(iVar9 + 8),
		                       Method_System_Collections_Generic_Dictionary_uint__List_ArtifactData___get_Item__
		                      );
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f8766c;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x25d,uVar12,uVar5,
		               Method_Sirenix_Utilities_LinqExtensions_AddRange_ArtifactData___);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f8766c:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f8767e:
		      iVar11 = global_1;
		      iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar11 == iVar9) {
		        piVar10 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar9 = *piVar10;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar9;
		        import::env::invoke_v(0x123);
		        iVar11 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar11 != 1) {
		code_r0x80f876c7:
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          return iVar2;
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x25e,&local_20);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 != 1) {
		        import::env::__resumeException(uVar4);
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
		    goto code_r0x80f87148;
		  }
		  DAT_ram_009d3e38 = 0;
		  iVar6 = import::env::invoke_ii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                     Gameplay_Inventory_View_Chest_ArtifactCategoryData_TypeInfo);
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80f8767e;
		  }
		  *(undefined4 *)(iVar6 + 8) = uVar5;
		  DAT_ram_009d3e38 = 0;
		  uVar12 = import::env::invoke_ii
		                     (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                      System_Collections_Generic_List_ArtifactData__TypeInfo);
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,uVar12,
		               Method_System_Collections_Generic_List_ArtifactData___ctor__);
		    if (DAT_ram_009d3e38 != 1) {
		      *(undefined4 *)(iVar6 + 0x10) = uVar12;
		      DAT_ram_009d3e38 = 0;
		      uVar12 = import::env::invoke_iiii
		                         (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                          *(undefined4 *)(iVar7 + 0x14),*(undefined4 *)(iVar9 + 8),
		                          Method_System_Collections_Generic_Dictionary_uint__ArtikulTypeFilters__get_Item__
		                         );
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f8767e;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar12 = import::env::invoke_iii
		                         (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x25c,uVar12,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f8767e;
		      }
		      *(undefined4 *)(iVar6 + 0xc) = uVar12;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,param1_00,uVar5,iVar6,
		                 Method_System_Collections_Generic_Dictionary_uint__ArtifactCategoryData__set_Item__
		                );
		      iVar8 = DAT_ram_009d3e38;
		      iVar7 = Method_System_Collections_Generic_List_ArtifactCategoryData__Add__;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f8767e;
		      }
		      *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		      uVar1 = *(uint *)(iVar2 + 0xc);
		      if (*(uint *)(*(int *)(iVar2 + 8) + 0xc) <= uVar1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,iVar6,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) goto code_r0x80f87567;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f8767e;
		      }
		      *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		      *(int *)(*(int *)(iVar2 + 8) + uVar1 * 4 + 0x10) = iVar6;
		      goto code_r0x80f87567;
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x80f8767e;
		}
		*/

		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60012B8")]
		[Address(RVA = "0x64B2", Offset = "0x64B2", VA = "0x64B2")]
		private List<ArtifactCategoryData> GetArtikulTypeGroupedData()
		{
		/* --- GHIDRA: GetArtikulTypeGroupedData ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__GetArtikulTypeGroupedData
		               (int *param1,undefined4 param2)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x160) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x164));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x144));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B9")]
		[Address(RVA = "0x64B3", Offset = "0x64B3", VA = "0x64B3", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x04000A1B RID: 2587
		[Token(Token = "0x4000A1B")]
		[FieldOffset(Offset = "0x18")]
		private TreasuryOptionListElement.TreasuryOptionListElementArgs _selectedArgs;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a58be5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusTreasuryModel__ColossusTreasuryEvents__ColossusTreasuryController__ColossusTreasuryView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ResourceSet__ResourceSet__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_ClanBalanceChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_InventoryChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_TreasuryOptionsRequestedEventHandler__
		              );
		    DAT_ram_00a58be5 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_TreasuryOptionsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x14);
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_InventoryChangedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_ResourceSet__ResourceSet__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_ClanBalanceChangedEventHandler__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_ResourceSet__ResourceSet__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x1c) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_ResourceSet__ResourceSet__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x1c) = iVar5;
		      uVar3 = System_Action_ResourceSet__ResourceSet__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_ResourceSet__ResourceSet__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_TreasuryOptionsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x14);
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_InventoryChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_ResourceSet__ResourceSet__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_ClanBalanceChangedEventHandler__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_ResourceSet__ResourceSet__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x1c) = 0;
		      return;
		    }
		    iVar5 = func_ii_1082(iVar2,System_Action_ResourceSet__ResourceSet__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x1c) = iVar5;
		    uVar3 = System_Action_ResourceSet__ResourceSet__TypeInfo;
		    iVar1 = func_ii_1082(iVar2,System_Action_ResourceSet__ResourceSet__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58be6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_BuyButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_CreateClanButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_ToTreasuryButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58be6 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x28) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_BuyButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x2c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_CreateClanButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x30) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_ToTreasuryButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  return;
		}
		*/

}
