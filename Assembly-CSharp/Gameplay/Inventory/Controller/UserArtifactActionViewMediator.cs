using System;
using Gameplay.Accounts.Model.Data;
using Gameplay.Inventory.Model;
using Il2CppDummyDll;

namespace Gameplay.Inventory.Controller
{
	// Token: 0x020006BD RID: 1725
	[Token(Token = "0x20006BD")]
	public class UserArtifactActionViewMediator : ArtifactActionBaseViewMediator<InventoryModel, InventoryEvents, InventoryController>
	{
		// Token: 0x060029C8 RID: 10696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C8")]
		[Address(RVA = "0x7A7E", Offset = "0x7A7E", VA = "0x7A7E")]
		public UserArtifactActionViewMediator(InventoryModel model, InventoryEvents events, InventoryController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_Controller_UserArtifactActionViewMediator___ctor
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5a188 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_InventoryModel__InventoryEvents__InventoryController__ArtifactActionPopupWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a5a188 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Gameplay_Inventory_View_ArtifactActionPopupWindow__get_WindowId(uVar1,0);
		  uVar1 = *(undefined4 *)(iVar2 + 0xb8);
		  iVar2 = param1[6];
		  param2_00 = *(undefined4 *)(param1[2] + 8);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  param3 = Core_Money_Money__op_Explicit(iVar2,0);
		  UI_Price_Price__SetColor(uVar1,param2_00,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C9")]
		[Address(RVA = "0x7A7F", Offset = "0x7A7F", VA = "0x7A7F", Slot = "23")]
		protected override void DrawPrice()
		{
		/* --- GHIDRA: DrawPrice ---
		void Gameplay_Inventory_Controller_UserArtifactActionViewMediator__DrawPrice
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a189 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__UseBattlePriceReforge__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__UseCommonPriceReforge__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__get_ArtifactData__
		              );
		    DAT_ram_00a5a189 = '\x01';
		  }
		  iVar1 = Gameplay_Accounts_Model_Data_AccountDataDecorator__get_BackTime(param1[8],0);
		  if (iVar1 == 0) {
		    iVar1 = *(int *)(*(int *)(param1[7] + 8) + 0x10);
		    iVar1 = Core_Extensions_Dict_ResourceSetExt__IsZero
		                      (*(undefined4 *)(iVar1 + 0x4c),*(undefined4 *)(iVar1 + 0x5c),0);
		    if (iVar1 == 0) {
		      Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_object__object__object___UseBattlePriceRepair
		                (param1,
		                 Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__UseCommonPriceReforge__
		                );
		    }
		    else {
		      Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_object__object__object___UseBattleAccountDiscount
		                (param1,
		                 Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__UseBattlePriceReforge__
		                );
		    }
		  }
		  else {
		    Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_object__object__object___UseBattlePriceRepair
		              (param1,
		               Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__UseCommonPriceReforge__
		              );
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x178) * 4))(param1,*(undefined4 *)(*param1 + 0x17c));
		  return;
		}
		*/

		}

		// Token: 0x060029CA RID: 10698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029CA")]
		[Address(RVA = "0x7A80", Offset = "0x7A80", VA = "0x7A80", Slot = "25")]
		protected override void InitReforgeCostButton()
		{
		/* --- GHIDRA: InitReforgeCostButton ---
		void Gameplay_Inventory_Controller_UserArtifactActionViewMediator__InitReforgeCostButton
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5a18a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__UseBattlePriceRepair__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__UseCommonPriceRepair__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__get_RepairBattlePrice__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__get_RepairPrice__
		              );
		    DAT_ram_00a5a18a = '\x01';
		  }
		  iVar1 = Gameplay_Accounts_Model_Data_AccountDataDecorator__get_BackTime(param1[8],0);
		  if (iVar1 == 0) {
		    param1_00 = Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_object__object__object___get_RepairFullPrice
		                          (param1,
		                           Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__get_RepairPrice__
		                          );
		    param2_00 = Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_object__object__object___get_ArtifactData
		                          (param1,
		                           Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__get_RepairBattlePrice__
		                          );
		    iVar1 = Core_Extensions_Dict_ResourceSetExt__IsZero(param1_00,param2_00,0);
		    if (iVar1 == 0) {
		      Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_object__object__object___UseCommonPriceReforge
		                (param1,
		                 Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__UseCommonPriceRepair__
		                );
		    }
		    else {
		      Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_object__object__object___UseBattlePriceReforge
		                (param1,
		                 Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__UseBattlePriceRepair__
		                );
		    }
		  }
		  else {
		    Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_object__object__object___UseCommonPriceReforge
		              (param1,
		               Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__UseCommonPriceRepair__
		              );
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x178) * 4))(param1,*(undefined4 *)(*param1 + 0x17c));
		  return;
		}
		*/

		}

		// Token: 0x060029CB RID: 10699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029CB")]
		[Address(RVA = "0x7A81", Offset = "0x7A81", VA = "0x7A81", Slot = "24")]
		protected override void InitRepairCostButton()
		{
		}

		// Token: 0x0400172A RID: 5930
		[Token(Token = "0x400172A")]
		[FieldOffset(Offset = "0x20")]
		protected readonly BattleAccount _battleAccount;
	}
}
