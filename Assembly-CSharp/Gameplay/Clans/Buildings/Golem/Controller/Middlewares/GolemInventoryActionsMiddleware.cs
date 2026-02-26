using System;
using Core.Data;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Inventory.Controller.Middlewares;
using Gameplay.Inventory.Model;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Clans.Buildings.Golem.Controller.Middlewares
{
	// Token: 0x02000AE4 RID: 2788
	[Token(Token = "0x2000AE4")]
	public class GolemInventoryActionsMiddleware : InventoryActionsMiddlewareBase<GolemInventoryModel>
	{
		// Token: 0x0600433D RID: 17213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600433D")]
		[Address(RVA = "0x91F1", Offset = "0x91F1", VA = "0x91F1")]
		public GolemInventoryActionsMiddleware(GolemInventoryModel model, UserData owner)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Clans_Buildings_Golem_Controller_Middlewares_GolemInventoryActionsMiddleware___ctor
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57acb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_GolemInventoryModel__get_Model__
		              );
		    DAT_ram_00a57acb = '\x01';
		  }
		  iVar1 = Core_Data_UserData__get_ClanId(*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		  if (iVar1 != 0) {
		    uVar2 = Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow__Show(param3,param2,0);
		    return uVar2;
		  }
		  uVar2 = Gameplay_Clans_Buildings_Golem_View_NoFreeSlotsDialogWindow__HandleCloseButton(0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x0600433E RID: 17214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600433E")]
		[Address(RVA = "0x91F2", Offset = "0x91F2", VA = "0x91F2", Slot = "4")]
		protected override OpToken<int, int> ShowInventoryConfirmBuySlotWindow(InvetoryScope scope, uint needCount)
		{
			return null;
		}
	}
}
