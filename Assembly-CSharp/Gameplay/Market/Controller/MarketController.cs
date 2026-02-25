using System;
using System.Collections.Generic;
using Gameplay.Market.Events;
using Gameplay.Market.Model;
using Gameplay.Market.View;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Shop;
using ServicesNamespace;
using Utils;
using Utils.Timers;

namespace Gameplay.Market.Controller
{
	// Token: 0x02000633 RID: 1587
	[Token(Token = "0x2000633")]
	public class MarketController : AbstractController<MarketModel, MarketEvents>
	{
		// Token: 0x0600266E RID: 9838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266E")]
		[Address(RVA = "0x77A7", Offset = "0x77A7", VA = "0x77A7")]
		public MarketController(MarketModel model, MarketEvents events, ShopService service)
		{
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266F")]
		[Address(RVA = "0x77A8", Offset = "0x77A8", VA = "0x77A8")]
		private void GetMarketArtifacts()
		{
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002670")]
		[Address(RVA = "0x77A9", Offset = "0x77A9", VA = "0x77A9")]
		private void GetMarketArtifactsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002671")]
		[Address(RVA = "0x77AA", Offset = "0x77AA", VA = "0x77AA")]
		public void GetUserOtherMarketArtifacts(ulong artifactId)
		{
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002672")]
		[Address(RVA = "0x77AB", Offset = "0x77AB", VA = "0x77AB")]
		private void GetUserOtherMarketArtifactsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002673")]
		[Address(RVA = "0x77AC", Offset = "0x77AC", VA = "0x77AC")]
		public void BuyMarketArtifact(ulong artifactId)
		{
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002674")]
		[Address(RVA = "0x77AD", Offset = "0x77AD", VA = "0x77AD")]
		private void BuyMarketArtifactResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002675")]
		[Address(RVA = "0x77AE", Offset = "0x77AE", VA = "0x77AE")]
		public void GetSimilarArtifacts(MarketLotListElement.MarketLotListElementArgs targetItem, IList<MarketLotListElement.MarketLotListElementArgs> availableLots)
		{
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002676")]
		[Address(RVA = "0x77AF", Offset = "0x77AF", VA = "0x77AF")]
		public void GetOptionsLots(MarketLotListElement.MarketLotListElementArgs targetItem, IList<MarketLotListElement.MarketLotListElementArgs> availableLots)
		{
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002677")]
		[Address(RVA = "0x77B0", Offset = "0x77B0", VA = "0x77B0")]
		public void GetOtherOptionsArtifacts(IList<MarketLotListElement.MarketLotListElementArgs> availableLots)
		{
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002678")]
		[Address(RVA = "0x77B1", Offset = "0x77B1", VA = "0x77B1", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002679")]
		[Address(RVA = "0x77B2", Offset = "0x77B2", VA = "0x77B2", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267A")]
		[Address(RVA = "0x77B3", Offset = "0x77B3", VA = "0x77B3")]
		private void HandleOptionExpired()
		{
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267B")]
		[Address(RVA = "0x77B4", Offset = "0x77B4", VA = "0x77B4")]
		private void HandleAddOption()
		{
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267C")]
		[Address(RVA = "0x77B5", Offset = "0x77B5", VA = "0x77B5")]
		private void ScheduleNextExpiration()
		{
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267D")]
		[Address(RVA = "0x77B6", Offset = "0x77B6", VA = "0x77B6")]
		private void ScheduleNextAddition()
		{
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267E")]
		[Address(RVA = "0x77B7", Offset = "0x77B7", VA = "0x77B7")]
		private void SubscribeToServiceEvents()
		{
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267F")]
		[Address(RVA = "0x77B8", Offset = "0x77B8", VA = "0x77B8")]
		private void UnsubscribeFromServiceEvents()
		{
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002680")]
		[Address(RVA = "0x77B9", Offset = "0x77B9", VA = "0x77B9")]
		private void MarketArtifactsRemovedEventHandler(ProtoMarketArtifactsRemovedEvt evt)
		{
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002681")]
		[Address(RVA = "0x77BA", Offset = "0x77BA", VA = "0x77BA")]
		private void MarketArtifactsAddedEventHandler(ProtoMarketArtifactsAddedEvt evt)
		{
		}

		// Token: 0x0400150F RID: 5391
		[Token(Token = "0x400150F")]
		[FieldOffset(Offset = "0x18")]
		private readonly ShopService _shopService;

		// Token: 0x04001510 RID: 5392
		[Token(Token = "0x4001510")]
		[FieldOffset(Offset = "0x1C")]
		private DelayedCall _removeTimer;

		// Token: 0x04001511 RID: 5393
		[Token(Token = "0x4001511")]
		[FieldOffset(Offset = "0x20")]
		private DelayedCall _addTimer;
	}
}
