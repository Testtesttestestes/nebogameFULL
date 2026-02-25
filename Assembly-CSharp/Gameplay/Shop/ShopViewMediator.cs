using System;
using Core.Data;
using Il2CppDummyDll;
using MVC;
using UI.Elements;
using UI.Windows.Buildings.ShopWindow;

namespace Gameplay.Shop
{
	// Token: 0x02000545 RID: 1349
	[Token(Token = "0x2000545")]
	public class ShopViewMediator : AbstractViewMediator<ShopModel, ShopEvents, ShopController, ShopWindow>
	{
		// Token: 0x0600205F RID: 8287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600205F")]
		[Address(RVA = "0x71C4", Offset = "0x71C4", VA = "0x71C4")]
		public ShopViewMediator(ShopModel model, ShopEvents events, ShopController controller)
		{
		}

		// Token: 0x170005E7 RID: 1511
		// (set) Token: 0x06002060 RID: 8288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E7")]
		public override ShopWindow View
		{
			[Token(Token = "0x6002060")]
			[Address(RVA = "0x71C5", Offset = "0x71C5", VA = "0x71C5", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (set) Token: 0x06002061 RID: 8289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E8")]
		public override ShopEvents Events
		{
			[Token(Token = "0x6002061")]
			[Address(RVA = "0x71C6", Offset = "0x71C6", VA = "0x71C6", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002062")]
		[Address(RVA = "0x71C7", Offset = "0x71C7", VA = "0x71C7")]
		private void Init()
		{
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002063")]
		[Address(RVA = "0x71C8", Offset = "0x71C8", VA = "0x71C8")]
		private void InitEventHandler()
		{
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002064")]
		[Address(RVA = "0x71C9", Offset = "0x71C9", VA = "0x71C9")]
		private void ItemsUpdatedEventHandler()
		{
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002065")]
		[Address(RVA = "0x71CA", Offset = "0x71CA", VA = "0x71CA")]
		private void OnSelectSlotEvent(int shopSlotId, ShopItem shopItem)
		{
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002066")]
		[Address(RVA = "0x71CB", Offset = "0x71CB", VA = "0x71CB")]
		private void SelectArtifactFromInventory()
		{
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x000067F8 File Offset: 0x000049F8
		[Token(Token = "0x6002067")]
		[Address(RVA = "0x71CC", Offset = "0x71CC", VA = "0x71CC")]
		private bool FilterShopArtifacts(ArtifactData artifactData)
		{
			return default(bool);
		}

		// Token: 0x040011AC RID: 4524
		[Token(Token = "0x40011AC")]
		private const string MY_SHOP_TIP = "SHOP/MY_SHOP_TIP";

		// Token: 0x040011AD RID: 4525
		[Token(Token = "0x40011AD")]
		private const string ANOTHER_SHOP_TIP = "SHOP/ANOTHER_SHOP_TIP";

		// Token: 0x040011AE RID: 4526
		[Token(Token = "0x40011AE")]
		private const string MY_ITEMS_TIP = "SHOP/MY_ITEMS_TIP";

		// Token: 0x040011AF RID: 4527
		[Token(Token = "0x40011AF")]
		private const string ANOTHER_ITEMS_TIP = "SHOP/ANOTHER_ITEMS_TIP";
	}
}
