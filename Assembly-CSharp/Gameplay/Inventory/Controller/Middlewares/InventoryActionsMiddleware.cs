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
