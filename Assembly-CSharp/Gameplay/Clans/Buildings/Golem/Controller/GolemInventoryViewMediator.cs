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
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004324")]
		[Address(RVA = "0x91D8", Offset = "0x91D8", VA = "0x91D8", Slot = "22")]
		protected override void RenderSlotsPrice()
		{
		}
	}
}
