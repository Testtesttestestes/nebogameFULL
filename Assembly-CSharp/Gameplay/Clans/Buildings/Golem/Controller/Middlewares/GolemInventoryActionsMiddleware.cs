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
