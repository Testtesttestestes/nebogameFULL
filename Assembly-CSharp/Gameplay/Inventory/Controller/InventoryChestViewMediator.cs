using System;
using Gameplay.Inventory.Model;
using Gameplay.Inventory.View.Chest;
using Il2CppDummyDll;

namespace Gameplay.Inventory.Controller
{
	// Token: 0x020006B7 RID: 1719
	[Token(Token = "0x20006B7")]
	public class InventoryChestViewMediator : InventoryBaseViewMediator<InventoryModel, InventoryEvents, InventoryController, UserInventoryChestWindow>
	{
		// Token: 0x060029A4 RID: 10660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A4")]
		[Address(RVA = "0x7A5A", Offset = "0x7A5A", VA = "0x7A5A")]
		public InventoryChestViewMediator(InventoryModel model, InventoryEvents events, InventoryController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_Controller_InventoryChestViewMediator___ctor
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  int *piVar5;
		  undefined4 param1_00;
		  int local_4;
		  
		  if (DAT_ram_00a5a169 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__UserInventoryChestWindow__set_View__
		              );
		    DAT_ram_00a5a169 = '\x01';
		  }
		  local_4 = 0;
		  Gameplay_Inventory_Controller_InventoryBaseViewMediator_object__object__object__object___set_Events
		            (param1,param2,
		             Method_Gameplay_Inventory_Controller_InventoryBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__UserInventoryChestWindow__set_View__
		            );
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar2,0);
		  if (iVar3 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *piVar5;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x248);
		          goto code_r0x811d71eb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x31);
		code_r0x811d71eb:
		    iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		    uVar1 = 0;
		    piVar5 = *(int **)(iVar3 + 0x20);
		    iVar3 = *piVar5;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x811d7270;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo,0);
		code_r0x811d7270:
		    iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,10,&local_4,puVar4[1]);
		    if (iVar3 != 0) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      param1_00 = *(undefined4 *)(iVar3 + 0x58);
		      uVar2 = Core_Extensions_Dict_DiscountsDicExt__GetDescription(*(undefined4 *)(local_4 + 8),0);
		      UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar2,0);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar3 + 0x58),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,1,0);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(iVar3 + 0x54),1,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x170007E2 RID: 2018
		// (set) Token: 0x060029A5 RID: 10661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E2")]
		public override UserInventoryChestWindow View
		{
			[Token(Token = "0x60029A5")]
			[Address(RVA = "0x7A5B", Offset = "0x7A5B", VA = "0x7A5B", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A6")]
		[Address(RVA = "0x7A5C", Offset = "0x7A5C", VA = "0x7A5C", Slot = "21")]
		protected override void BuySlotClickHandler()
		{
		/* --- GHIDRA: BuySlotClickHandler ---
		void Gameplay_Inventory_Controller_InventoryChestViewMediator__BuySlotClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  
		  if (DAT_ram_00a5a16b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_InventoryModel__InventoryEvents__InventoryController__UserInventoryChestWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a5a16b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x4c) + 0x14) + 0xb8);
		  piVar3 = (int *)param1[2];
		  iVar1 = piVar3[2];
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x118) * 4))
		                    (piVar3,1,*(undefined4 *)(*piVar3 + 0x11c));
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  UI_Price_Price__SetColor(param1_00,iVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A7")]
		[Address(RVA = "0x7A5D", Offset = "0x7A5D", VA = "0x7A5D", Slot = "22")]
		protected override void RenderSlotsPrice()
		{
		/* --- GHIDRA: RenderSlotsPrice ---
		void Gameplay_Inventory_Controller_InventoryChestViewMediator__RenderSlotsPrice
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a16c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__Dispose__
		              );
		    DAT_ram_00a5a16c = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x2c) = 0;
		  *(undefined8 *)(param1 + 0x24) = 0;
		  Gameplay_Inventory_Controller_InventoryBaseController_object__object___DismantleArtifactSuccessHandler
		            (param1,
		             Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__Dispose__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Inventory_Controller_InventoryChestViewMediator__set_View
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  longlong lVar3;
		  int param1_00;
		  
		  if (DAT_ram_00a5a16a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_InventoryModel__InventoryEvents__InventoryController__UserInventoryChestWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6904);
		    DAT_ram_00a5a16a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  iVar1 = *(int *)(param1_00 + 0x3c);
		  lVar3 = Gameplay_Inventory_Model_InventoryBaseModel__TryGetFitSlotId(param1_00,param1_00);
		  if (lVar3 <= iVar1) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6904,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar2,1,param3,0);
		    return;
		  }
		  Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow__HandleContent(1,3,param1_00);
		  return;
		}
		*/

}
