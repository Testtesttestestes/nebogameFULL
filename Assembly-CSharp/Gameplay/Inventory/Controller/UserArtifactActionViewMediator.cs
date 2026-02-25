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
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C9")]
		[Address(RVA = "0x7A7F", Offset = "0x7A7F", VA = "0x7A7F", Slot = "23")]
		protected override void DrawPrice()
		{
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029CA")]
		[Address(RVA = "0x7A80", Offset = "0x7A80", VA = "0x7A80", Slot = "25")]
		protected override void InitReforgeCostButton()
		{
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
