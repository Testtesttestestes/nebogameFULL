using System;
using Gameplay.Inventory.View;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005E0 RID: 1504
	[Token(Token = "0x20005E0")]
	public class PortalsShopController : AbstractController<PortalsShopModel, PortalsEvents>
	{
		// Token: 0x06002453 RID: 9299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002453")]
		[Address(RVA = "0x75A1", Offset = "0x75A1", VA = "0x75A1")]
		public PortalsShopController(PortalsShopModel model, PortalsEvents events, PortalsService portalsService)
		{
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002454")]
		[Address(RVA = "0x75A2", Offset = "0x75A2", VA = "0x75A2")]
		public void GetStoreItemsInfo()
		{
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002455")]
		[Address(RVA = "0x75A3", Offset = "0x75A3", VA = "0x75A3")]
		private void OnGetStoreItemsInfo(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002456")]
		[Address(RVA = "0x75A4", Offset = "0x75A4", VA = "0x75A4")]
		public void BuyShopItem(IArtifactView item)
		{
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002457")]
		[Address(RVA = "0x75A5", Offset = "0x75A5", VA = "0x75A5")]
		private void OnBuyEventShopItem(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x040013FC RID: 5116
		[Token(Token = "0x40013FC")]
		[FieldOffset(Offset = "0x18")]
		private readonly PortalsService _portalsService;
	}
}
