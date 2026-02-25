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
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A7")]
		[Address(RVA = "0x7A5D", Offset = "0x7A5D", VA = "0x7A5D", Slot = "22")]
		protected override void RenderSlotsPrice()
		{
		}
	}
}
