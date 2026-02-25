using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Shop;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	public class ShopService : AbstractService
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x000030C0 File Offset: 0x000012C0
		[Token(Token = "0x170000AC")]
		public override short ServiceId
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x5A5C", Offset = "0x5A5C", VA = "0x5A5C", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x140000A0 RID: 160
		// (add) Token: 0x0600065C RID: 1628 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600065D RID: 1629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A0")]
		public event Action<ProtoArtifactBuyedEvt> ArtifactBuyedEvent
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x5A5D", Offset = "0x5A5D", VA = "0x5A5D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600065D")]
			[Address(RVA = "0x5A5E", Offset = "0x5A5E", VA = "0x5A5E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000A1 RID: 161
		// (add) Token: 0x0600065E RID: 1630 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600065F RID: 1631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A1")]
		public event Action<ProtoArtifactMovedEvt> ArtifactMovedEvent
		{
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x5A5F", Offset = "0x5A5F", VA = "0x5A5F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x5A60", Offset = "0x5A60", VA = "0x5A60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000A2 RID: 162
		// (add) Token: 0x06000660 RID: 1632 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000661 RID: 1633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A2")]
		public event Action<ProtoMarketArtifactsAddedEvt> MarketArtifactsAddedEvent
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x5A61", Offset = "0x5A61", VA = "0x5A61")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x5A62", Offset = "0x5A62", VA = "0x5A62")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000A3 RID: 163
		// (add) Token: 0x06000662 RID: 1634 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000663 RID: 1635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A3")]
		public event Action<ProtoMarketArtifactsRemovedEvt> MarketArtifactsRemovedEvent
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x5A63", Offset = "0x5A63", VA = "0x5A63")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x5A64", Offset = "0x5A64", VA = "0x5A64")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000A4 RID: 164
		// (add) Token: 0x06000664 RID: 1636 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000665 RID: 1637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A4")]
		public event Action<ProtoMarketOptionsDisabledEvt> MarketOptionsDisabledEvent
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x5A65", Offset = "0x5A65", VA = "0x5A65")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x5A66", Offset = "0x5A66", VA = "0x5A66")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x5A67", Offset = "0x5A67", VA = "0x5A67", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x5A68", Offset = "0x5A68", VA = "0x5A68")]
		public OpToken<IMessage, object> GetShopItemsInfo(ulong ownerId)
		{
			return null;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x5A69", Offset = "0x5A69", VA = "0x5A69")]
		public OpToken<IMessage, object> BuyArtifact(ulong ownerId, ulong artId, uint destSlotId)
		{
			return null;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x5A6A", Offset = "0x5A6A", VA = "0x5A6A")]
		public OpToken<IMessage, object> MoveArtifactFromUserToShop(ulong artId, uint destSlotId, ResourceSet price)
		{
			return null;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x5A6B", Offset = "0x5A6B", VA = "0x5A6B")]
		public OpToken<IMessage, object> MoveArtifactFromShopToUser(ulong artId, uint destSlotId)
		{
			return null;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x5A6C", Offset = "0x5A6C", VA = "0x5A6C")]
		public OpToken<IMessage, object> GetArtifactMinPrice(ulong artId)
		{
			return null;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x5A6D", Offset = "0x5A6D", VA = "0x5A6D")]
		public OpToken<IMessage, object> GetMarketArtifacts()
		{
			return null;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x5A6E", Offset = "0x5A6E", VA = "0x5A6E")]
		public OpToken<IMessage, object> GetUserOtherMarketArtifacts(ulong artifactId)
		{
			return null;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x5A6F", Offset = "0x5A6F", VA = "0x5A6F")]
		public OpToken<IMessage, object> BuyMarketArtifact(ulong artifactId, uint destSlotId)
		{
			return null;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x5A70", Offset = "0x5A70", VA = "0x5A70")]
		public OpToken<IMessage, object> ExitMarket()
		{
			return null;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000670")]
		private OpToken<IMessage, object> Request<TAns>(ShopCommands command, IMessage msg) where TAns : IMessage, new()
		{
			return null;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000671")]
		private OpToken<IMessage, object> Request<TAns, TMsg>(ShopCommands command, IMessage<TMsg> msg) where TAns : IMessage, new() where TMsg : IMessage<TMsg>
		{
			return null;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x5A71", Offset = "0x5A71", VA = "0x5A71")]
		public ShopService()
		{
		}
	}
}
