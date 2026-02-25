using System;
using System.Collections.Generic;
using Gameplay.Inventory.View;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Gameplay.Portals.View.ShopTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using UI;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005E2 RID: 1506
	[Token(Token = "0x20005E2")]
	public class PortalsShopViewMediator : AbstractViewMediator<PortalsShopModel, PortalsEvents, PortalsShopController, PortalsShopView>, IHideableMediator
	{
		// Token: 0x0600245A RID: 9306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245A")]
		[Address(RVA = "0x75A8", Offset = "0x75A8", VA = "0x75A8")]
		public PortalsShopViewMediator(PortalsShopModel model, PortalsEvents events, PortalsShopController controller)
		{
		}

		// Token: 0x170006D5 RID: 1749
		// (set) Token: 0x0600245B RID: 9307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D5")]
		public override PortalsShopView View
		{
			[Token(Token = "0x600245B")]
			[Address(RVA = "0x75A9", Offset = "0x75A9", VA = "0x75A9", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245C")]
		[Address(RVA = "0x75AA", Offset = "0x75AA", VA = "0x75AA", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245D")]
		[Address(RVA = "0x75AB", Offset = "0x75AB", VA = "0x75AB")]
		private void SetupView()
		{
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245E")]
		[Address(RVA = "0x75AC", Offset = "0x75AC", VA = "0x75AC")]
		private void BuyShopItem(IArtifactView item)
		{
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245F")]
		[Address(RVA = "0x75AD", Offset = "0x75AD", VA = "0x75AD")]
		private void PopupOnClose()
		{
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002460")]
		[Address(RVA = "0x75AE", Offset = "0x75AE", VA = "0x75AE")]
		private void UpdateMessage()
		{
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002461")]
		[Address(RVA = "0x75AF", Offset = "0x75AF", VA = "0x75AF")]
		private void UserInfoChangedHandler()
		{
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002462")]
		[Address(RVA = "0x75B0", Offset = "0x75B0", VA = "0x75B0")]
		private void GetStoreItemsHandler()
		{
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002463")]
		[Address(RVA = "0x75B1", Offset = "0x75B1", VA = "0x75B1")]
		private List<ShopItemData> FilterItems(List<ShopItemData> shopItems)
		{
			return null;
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002464")]
		[Address(RVA = "0x75B2", Offset = "0x75B2", VA = "0x75B2")]
		private void FiltersViewChangedEventHandler()
		{
		}

		// Token: 0x04001400 RID: 5120
		[Token(Token = "0x4001400")]
		[FieldOffset(Offset = "0x18")]
		private NotEnoughPortalsScoreWindow _popup;
	}
}
