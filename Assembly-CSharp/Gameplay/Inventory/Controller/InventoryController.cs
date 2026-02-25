using System;
using Core.Data;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Inventory.Controller.Middlewares;
using Gameplay.Inventory.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Main;
using ServicesNamespace;
using UI.Windows;
using Utils;

namespace Gameplay.Inventory.Controller
{
	// Token: 0x020006B8 RID: 1720
	[Token(Token = "0x20006B8")]
	public class InventoryController : InventoryBaseController<InventoryModel, InventoryEvents>
	{
		// Token: 0x060029A8 RID: 10664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A8")]
		[Address(RVA = "0x7A5E", Offset = "0x7A5E", VA = "0x7A5E", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A9")]
		[Address(RVA = "0x7A5F", Offset = "0x7A5F", VA = "0x7A5F")]
		public InventoryController(InventoryModel model, InventoryEvents events, DismantleMiddleware dismantleMiddleware, InventoryActionsMiddlewareBase<InventoryModel> middlewareActions, MainService mainService, ServicesService servicesService, CraftService craftService)
		{
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029AA")]
		[Address(RVA = "0x7A60", Offset = "0x7A60", VA = "0x7A60", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029AB")]
		[Address(RVA = "0x7A61", Offset = "0x7A61", VA = "0x7A61", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029AC")]
		[Address(RVA = "0x7A62", Offset = "0x7A62", VA = "0x7A62")]
		private void OnInventoryChangedEvent(ProtoInventoryChangedEvt evt)
		{
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029AD")]
		[Address(RVA = "0x7A63", Offset = "0x7A63", VA = "0x7A63")]
		protected void HandleGetUserArtifactsRequest(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029AE")]
		[Address(RVA = "0x7A64", Offset = "0x7A64", VA = "0x7A64", Slot = "18")]
		public override void SellItem(ArtifactData artifactData)
		{
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029AF")]
		[Address(RVA = "0x7A65", Offset = "0x7A65", VA = "0x7A65", Slot = "19")]
		public override void RepairArtifact(ResourceSet price, params uint[] slotIds)
		{
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B0")]
		[Address(RVA = "0x7A66", Offset = "0x7A66", VA = "0x7A66")]
		public void RestoreItem(uint slotId)
		{
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B1")]
		[Address(RVA = "0x7A67", Offset = "0x7A67", VA = "0x7A67", Slot = "20")]
		public override void ReforgeArtifact(ResourceSet price, uint slotId)
		{
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B2")]
		[Address(RVA = "0x7A68", Offset = "0x7A68", VA = "0x7A68")]
		private void RestoreUserItemHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B3")]
		[Address(RVA = "0x7A69", Offset = "0x7A69", VA = "0x7A69", Slot = "14")]
		protected override void HandleSuccessDismantle(InventoryController.DismantleArtifactVO dismantleInformation)
		{
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B4")]
		[Address(RVA = "0x7A6A", Offset = "0x7A6A", VA = "0x7A6A")]
		private void SellArtifactSuccessHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B5")]
		[Address(RVA = "0x7A6B", Offset = "0x7A6B", VA = "0x7A6B")]
		public void MoveItemToBag(ArtifactData artifact)
		{
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B6")]
		[Address(RVA = "0x7A6C", Offset = "0x7A6C", VA = "0x7A6C", Slot = "16")]
		public override void RequestMoveItemTo(ArtifactData artifact, int slotId)
		{
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B7")]
		[Address(RVA = "0x7A6D", Offset = "0x7A6D", VA = "0x7A6D")]
		public void SetArtifactFavorite(ArtifactData artifactData, bool favorite)
		{
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B8")]
		[Address(RVA = "0x7A6E", Offset = "0x7A6E", VA = "0x7A6E")]
		public void MergeAllStackableItems(uint slotId)
		{
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B9")]
		[Address(RVA = "0x7A6F", Offset = "0x7A6F", VA = "0x7A6F")]
		private void MergeArtifactResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BA")]
		[Address(RVA = "0x7A70", Offset = "0x7A70", VA = "0x7A70")]
		public void SplitArtifact(uint slotId, uint quantity)
		{
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BB")]
		[Address(RVA = "0x7A71", Offset = "0x7A71", VA = "0x7A71")]
		private void SplitArtifactResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60029BC")]
		[Address(RVA = "0x7A72", Offset = "0x7A72", VA = "0x7A72", Slot = "17")]
		public override OpToken<IMessage, object> BuySlots(uint quantity)
		{
			return null;
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BD")]
		[Address(RVA = "0x7A73", Offset = "0x7A73", VA = "0x7A73")]
		protected void BuySlotHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BE")]
		[Address(RVA = "0x7A74", Offset = "0x7A74", VA = "0x7A74")]
		protected void SwapSlotsSuccessHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BF")]
		[Address(RVA = "0x7A75", Offset = "0x7A75", VA = "0x7A75", Slot = "15")]
		public override void MoveItemToChest(ArtifactData artifactData)
		{
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C0")]
		[Address(RVA = "0x7A76", Offset = "0x7A76", VA = "0x7A76", Slot = "13")]
		public override void DismantleArtifact(ArtifactData artifactData, bool sellDrop = false, bool wholeStack = false)
		{
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60029C1")]
		[Address(RVA = "0x7A77", Offset = "0x7A77", VA = "0x7A77")]
		public DialogWindow ShowRecipeLearnedWindow(string title, ArtikulDicWrapper artikul, IDictProvider dictProvider)
		{
			return null;
		}

		// Token: 0x04001721 RID: 5921
		[Token(Token = "0x4001721")]
		[FieldOffset(Offset = "0x24")]
		private MainService _mainService;

		// Token: 0x04001722 RID: 5922
		[Token(Token = "0x4001722")]
		[FieldOffset(Offset = "0x28")]
		private ServicesService _servicesService;

		// Token: 0x04001723 RID: 5923
		[Token(Token = "0x4001723")]
		[FieldOffset(Offset = "0x2C")]
		private DismantleMiddleware _dismantleMiddleware;

		// Token: 0x020006B9 RID: 1721
		[Token(Token = "0x20006B9")]
		public class DismantleArtifactVO
		{
			// Token: 0x060029C2 RID: 10690 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60029C2")]
			[Address(RVA = "0x7A78", Offset = "0x7A78", VA = "0x7A78")]
			public DismantleArtifactVO(ArtifactData artifact)
			{
			}

			// Token: 0x04001724 RID: 5924
			[Token(Token = "0x4001724")]
			[FieldOffset(Offset = "0x8")]
			public readonly ArtifactData Artifact;

			// Token: 0x04001725 RID: 5925
			[Token(Token = "0x4001725")]
			[FieldOffset(Offset = "0xC")]
			public bool SellDrop;

			// Token: 0x04001726 RID: 5926
			[Token(Token = "0x4001726")]
			[FieldOffset(Offset = "0xD")]
			public bool WholeStack;
		}
	}
}
