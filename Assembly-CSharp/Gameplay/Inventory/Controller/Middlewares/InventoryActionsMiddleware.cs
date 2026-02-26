using System;
using Core.Data;
using Gameplay.Inventory.Model;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Inventory.Controller.Middlewares
{
	// Token: 0x020006C0 RID: 1728
	[Token(Token = "0x20006C0")]
	public class InventoryActionsMiddleware : InventoryActionsMiddlewareBase<InventoryModel>
	{
		// Token: 0x060029D3 RID: 10707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029D3")]
		[Address(RVA = "0x7A89", Offset = "0x7A89", VA = "0x7A89")]
		public InventoryActionsMiddleware(InventoryModel model, UserData owner)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddleware___ctor
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow__HandleContent
		                    (param3,param2,param2);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60029D4")]
		[Address(RVA = "0x7A8A", Offset = "0x7A8A", VA = "0x7A8A", Slot = "4")]
		protected override OpToken<int, int> ShowInventoryConfirmBuySlotWindow(InvetoryScope scope, uint needCount)
		{
			return null;
		}
	}
}
