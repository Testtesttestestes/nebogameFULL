using System;
using Gameplay.Clans.Buildings.Golem.Events;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Inventory.Controller;
using Il2CppDummyDll;

namespace Gameplay.Clans.Buildings.Golem.Controller
{
	// Token: 0x02000ADB RID: 2779
	[Token(Token = "0x2000ADB")]
	public class GolemArtifactActionViewMediator : ArtifactActionBaseViewMediator<GolemInventoryModel, GolemInventoryEvents, GolemInventoryController>
	{
		// Token: 0x060042EE RID: 17134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EE")]
		[Address(RVA = "0x91A2", Offset = "0x91A2", VA = "0x91A2")]
		public GolemArtifactActionViewMediator(GolemInventoryModel model, GolemInventoryEvents events, GolemInventoryController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemArtifactActionViewMediator___ctor
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 param3;
		  int *param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57a84 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a57a84 = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = Gameplay_Inventory_View_ArtifactActionPopupWindow__get_WindowId(uVar2,0);
		  uVar2 = *(undefined4 *)(iVar3 + 0xb8);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		        goto code_r0x80e1a1a3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e1a1a3:
		  iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  param2_00 = *(undefined4 *)(*(int *)(iVar3 + 0x10) + 0x18);
		  iVar3 = param1[6];
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  param3 = Core_Money_Money__op_Explicit(iVar3,0);
		  UI_Price_Price__SetColor(uVar2,param2_00,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x060042EF RID: 17135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EF")]
		[Address(RVA = "0x91A3", Offset = "0x91A3", VA = "0x91A3", Slot = "23")]
		protected override void DrawPrice()
		{
		/* --- GHIDRA: DrawPrice ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemArtifactActionViewMediator__DrawPrice
		               (int *param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57a85 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_GolemInventoryModel__GolemInventoryEvents__GolemInventoryController__UseCommonPriceReforge__
		              );
		    DAT_ram_00a57a85 = '\x01';
		  }
		  Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_object__object__object___UseBattlePriceRepair
		            (param1,
		             Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_GolemInventoryModel__GolemInventoryEvents__GolemInventoryController__UseCommonPriceReforge__
		            );
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x178) * 4))(param1,*(undefined4 *)(*param1 + 0x17c));
		  return;
		}
		*/

		}

		// Token: 0x060042F0 RID: 17136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F0")]
		[Address(RVA = "0x91A4", Offset = "0x91A4", VA = "0x91A4", Slot = "25")]
		protected override void InitReforgeCostButton()
		{
		/* --- GHIDRA: InitReforgeCostButton ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemArtifactActionViewMediator__InitReforgeCostButton
		               (int *param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57a86 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_GolemInventoryModel__GolemInventoryEvents__GolemInventoryController__UseCommonPriceRepair__
		              );
		    DAT_ram_00a57a86 = '\x01';
		  }
		  Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_object__object__object___UseCommonPriceReforge
		            (param1,
		             Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_GolemInventoryModel__GolemInventoryEvents__GolemInventoryController__UseCommonPriceRepair__
		            );
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x178) * 4))(param1,*(undefined4 *)(*param1 + 0x17c));
		  return;
		}
		*/

		}

		// Token: 0x060042F1 RID: 17137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F1")]
		[Address(RVA = "0x91A5", Offset = "0x91A5", VA = "0x91A5", Slot = "24")]
		protected override void InitRepairCostButton()
		{
		/* --- GHIDRA: InitRepairCostButton ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemArtifactActionViewMediator__InitRepairCostButton
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57a87 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_GolemModel__GolemEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a57a87 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_GolemModel__GolemEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}
	}
}
