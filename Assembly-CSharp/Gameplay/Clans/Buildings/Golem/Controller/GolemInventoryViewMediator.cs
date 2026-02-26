using System;
using Gameplay.Clans.Buildings.Golem.Events;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Clans.Buildings.Golem.View;
using Gameplay.Inventory.Controller;
using Il2CppDummyDll;

namespace Gameplay.Clans.Buildings.Golem.Controller
{
	// Token: 0x02000AE1 RID: 2785
	[Token(Token = "0x2000AE1")]
	public class GolemInventoryViewMediator : InventoryBaseViewMediator<GolemInventoryModel, GolemInventoryEvents, GolemInventoryController, GolemInventoryChestWindow>
	{
		// Token: 0x06004320 RID: 17184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004320")]
		[Address(RVA = "0x91D4", Offset = "0x91D4", VA = "0x91D4")]
		public GolemInventoryViewMediator(GolemInventoryModel model, GolemInventoryEvents events, GolemInventoryController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryViewMediator___ctor
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57ab1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemInventoryModel__GolemInventoryEvents__GolemInventoryController__GolemInventoryChestWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseViewMediator_GolemInventoryModel__GolemInventoryEvents__GolemInventoryController__GolemInventoryChestWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57ab1 = '\x01';
		  }
		  Gameplay_Inventory_Controller_InventoryBaseViewMediator_object__object__object__object___set_Events
		            (param1,param2,
		             Method_Gameplay_Inventory_Controller_InventoryBaseViewMediator_GolemInventoryModel__GolemInventoryEvents__GolemInventoryController__GolemInventoryChestWindow__set_View__
		            );
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0x14),0);
		    param2_00 = Core_Data_UserData__get_ClanId(*(undefined4 *)(param1[2] + 8),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000D3A RID: 3386
		// (set) Token: 0x06004321 RID: 17185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3A")]
		public override GolemInventoryChestWindow View
		{
			[Token(Token = "0x6004321")]
			[Address(RVA = "0x91D5", Offset = "0x91D5", VA = "0x91D5", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (set) Token: 0x06004322 RID: 17186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3B")]
		public override GolemInventoryEvents Events
		{
			[Token(Token = "0x6004322")]
			[Address(RVA = "0x91D6", Offset = "0x91D6", VA = "0x91D6", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004323")]
		[Address(RVA = "0x91D7", Offset = "0x91D7", VA = "0x91D7", Slot = "21")]
		protected override void BuySlotClickHandler()
		{
		/* --- GHIDRA: BuySlotClickHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryViewMediator__BuySlotClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57ab4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemInventoryModel__GolemInventoryEvents__GolemInventoryController__GolemInventoryChestWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a57ab4 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x4c) + 0x14) + 0xb8);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x230);
		        goto code_r0x80e1cf4c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e1cf4c:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  param2_00 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0x18);
		  iVar2 = *(int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x118) * 4))
		                    ((int *)param1[2],1,*(undefined4 *)(iVar2 + 0x11c));
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar4 = Core_Money_Money__op_Explicit(uVar4,0);
		  UI_Price_Price__SetColor(param1_00,param2_00,uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x06004324 RID: 17188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004324")]
		[Address(RVA = "0x91D8", Offset = "0x91D8", VA = "0x91D8", Slot = "22")]
		protected override void RenderSlotsPrice()
		{
		/* --- GHIDRA: RenderSlotsPrice ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryViewMediator__RenderSlotsPrice
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57ab5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57ab5 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow___ctor__
		            );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x230);
		        goto code_r0x80e1d086;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e1d086:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x240);
		        goto code_r0x80e1d135;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x30);
		code_r0x80e1d135:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  *(undefined4 *)(param1 + 0x1c) = uVar3;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryViewMediator__set_View
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a57ab2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseViewMediator_GolemInventoryModel__GolemInventoryEvents__GolemInventoryController__GolemInventoryChestWindow__InventoryChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseViewMediator_GolemInventoryModel__GolemInventoryEvents__GolemInventoryController__GolemInventoryChestWindow__set_Events__
		              );
		    DAT_ram_00a57ab2 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar2 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x120);
		          goto code_r0x80e1cb1f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80e1cb1f:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    iVar6 = *(int *)(iVar2 + 0x20);
		    uVar7 = *(undefined4 *)(iVar6 + 0x14);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Inventory_Controller_InventoryBaseViewMediator_GolemInventoryModel__GolemInventoryEvents__GolemInventoryController__GolemInventoryChestWindow__InventoryChangedEventHandler__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar7,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar6 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar6 + 0x14) = piVar5, *piVar5 != iVar2)) {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Gameplay_Inventory_Controller_InventoryBaseViewMediator_object__object__object__object___get_IsAnyFilterEnabled
		            (param1,param2,
		             Method_Gameplay_Inventory_Controller_InventoryBaseViewMediator_GolemInventoryModel__GolemInventoryEvents__GolemInventoryController__GolemInventoryChestWindow__set_Events__
		            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar2 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x120);
		          goto code_r0x80e1cc55;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80e1cc55:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    iVar6 = *(int *)(iVar2 + 0x20);
		    uVar7 = *(undefined4 *)(iVar6 + 0x14);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Inventory_Controller_InventoryBaseViewMediator_GolemInventoryModel__GolemInventoryEvents__GolemInventoryController__GolemInventoryChestWindow__InventoryChangedEventHandler__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar7,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar6 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar5) || (*(int **)(iVar6 + 0x14) = piVar5, *piVar5 != iVar2))
		    {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryViewMediator__set_Events
		               (int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 uVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a57ab3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemInventoryModel__GolemInventoryEvents__GolemInventoryController__GolemInventoryChestWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6904);
		    DAT_ram_00a57ab3 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar6 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 0x230);
		        goto code_r0x80e1cdb1;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e1cdb1:
		  iVar4 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		  uVar5 = *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x18) + 8);
		  iVar4 = **(int **)(param1 + 8);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x118) * 4))
		                    (*(int **)(param1 + 8),1,*(undefined4 *)(iVar4 + 0x11c));
		  iVar4 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle(uVar5,uVar2,0);
		  if (iVar4 != 0) {
		    iVar4 = *(int *)(*(int *)(param1 + 8) + 0x3c);
		    lVar3 = Gameplay_Inventory_Model_InventoryBaseModel__TryGetFitSlotId
		                      (*(undefined4 *)(param1 + 8),0);
		    if (lVar3 <= iVar4) {
		      uVar2 = System_Uri___ctor(0);
		      uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6904,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar2,1,uVar5,0);
		      return;
		    }
		    Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow__Show(1,3,0);
		  }
		  return;
		}
		*/

}
