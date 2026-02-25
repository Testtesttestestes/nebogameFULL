using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Shop;
using ServicesNamespace;
using Utils;

namespace Gameplay.Shop
{
	// Token: 0x02000542 RID: 1346
	[Token(Token = "0x2000542")]
	public class ShopController : AbstractController<ShopModel, ShopEvents>
	{
		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x000067E0 File Offset: 0x000049E0
		// (set) Token: 0x06002049 RID: 8265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E6")]
		public bool ItemsRequested
		{
			[Token(Token = "0x6002048")]
			[Address(RVA = "0x71AD", Offset = "0x71AD", VA = "0x71AD")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002049")]
			[Address(RVA = "0x71AE", Offset = "0x71AE", VA = "0x71AE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204A")]
		[Address(RVA = "0x71AF", Offset = "0x71AF", VA = "0x71AF")]
		public ShopController(ShopModel model, ShopEvents events)
		{
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204B")]
		[Address(RVA = "0x71B0", Offset = "0x71B0", VA = "0x71B0", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204C")]
		[Address(RVA = "0x71B1", Offset = "0x71B1", VA = "0x71B1", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204D")]
		[Address(RVA = "0x71B2", Offset = "0x71B2", VA = "0x71B2")]
		private void BuildingStateChangedEvent(uint building)
		{
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204E")]
		[Address(RVA = "0x71B3", Offset = "0x71B3", VA = "0x71B3")]
		private void OnArtifactBuyed(ProtoArtifactBuyedEvt evt)
		{
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204F")]
		[Address(RVA = "0x71B4", Offset = "0x71B4", VA = "0x71B4")]
		private void OnArtifactMoved(ProtoArtifactMovedEvt evt)
		{
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002050")]
		[Address(RVA = "0x71B5", Offset = "0x71B5", VA = "0x71B5")]
		public void RequestShopItems()
		{
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002051")]
		[Address(RVA = "0x71B6", Offset = "0x71B6", VA = "0x71B6")]
		private void RequestShopItemsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002052")]
		[Address(RVA = "0x71B7", Offset = "0x71B7", VA = "0x71B7")]
		public void MoveItemToLastSelectedOrFirstEmpty(ArtifactData artifactData, bool toNeboMarket)
		{
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002053")]
		[Address(RVA = "0x71B8", Offset = "0x71B8", VA = "0x71B8")]
		private void OnItemsMovedToShop(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002054")]
		[Address(RVA = "0x71B9", Offset = "0x71B9", VA = "0x71B9")]
		public void TakeoffArtifactFromShop(ArtifactData shopArtifact, bool equip = false)
		{
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002055")]
		[Address(RVA = "0x71BA", Offset = "0x71BA", VA = "0x71BA")]
		public void BuyArtifactFromAnotherShop(ArtifactData shopArtifact, bool equip = false)
		{
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002056")]
		[Address(RVA = "0x71BB", Offset = "0x71BB", VA = "0x71BB")]
		private void MoveItemFromShop(ArtifactData shopArtifact, uint destSlotId)
		{
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002057")]
		[Address(RVA = "0x71BC", Offset = "0x71BC", VA = "0x71BC")]
		private void MoveItemFromShopResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002058")]
		[Address(RVA = "0x71BD", Offset = "0x71BD", VA = "0x71BD")]
		private void BuyArtifactFromShop(ArtifactData shopArtifact, uint destSlotId)
		{
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002059")]
		[Address(RVA = "0x71BE", Offset = "0x71BE", VA = "0x71BE")]
		private void BuyArtifactFromShopResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600205A")]
		[Address(RVA = "0x71BF", Offset = "0x71BF", VA = "0x71BF", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x040011A6 RID: 4518
		[Token(Token = "0x40011A6")]
		[FieldOffset(Offset = "0x18")]
		private ShopService _shopService;
	}
}
