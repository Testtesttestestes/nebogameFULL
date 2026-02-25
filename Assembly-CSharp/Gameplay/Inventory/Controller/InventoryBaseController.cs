using System;
using System.Collections.Generic;
using Core.Data;
using Core.Errors.Expected;
using Gameplay.Inventory.Controller.Middlewares;
using Gameplay.Inventory.Events;
using Gameplay.Inventory.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Main;
using ServicesNamespace;
using UI.Windows;
using Utils;
using Utils.Accumulators;

namespace Gameplay.Inventory.Controller
{
	// Token: 0x020006B1 RID: 1713
	[Token(Token = "0x20006B1")]
	public abstract class InventoryBaseController<M, E> : AbstractController<M, E>, IInventory where M : InventoryBaseModel where E : InventoryBaseEvents
	{
		// Token: 0x06002971 RID: 10609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002971")]
		public override void Dispose()
		{
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002972")]
		protected InventoryBaseController(M model, E events, InventoryActionsMiddlewareBase<M> middlewareActions, CraftService craftService)
		{
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002973")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002974")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002975")]
		public void ParseSlotChanges(IList<UserArtifact> changes)
		{
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002976")]
		protected void ReforgeItemResultHandler<T>(OpToken<IMessage, object> op) where T : ExpectedDefaultError, new()
		{
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002977")]
		protected void RepairItemSuccessHandler<T>(OpToken<IMessage, object> op) where T : ExpectedDefaultError, new()
		{
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002978")]
		public void Unequip(ArtifactData artifact)
		{
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002979")]
		public void Equip(ArtifactData artifact)
		{
		}

		// Token: 0x0600297A RID: 10618
		[Token(Token = "0x600297A")]
		public abstract void DismantleArtifact(ArtifactData artifactData, bool sellDrop = false, bool wholeStack = false);

		// Token: 0x0600297B RID: 10619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297B")]
		protected void DismantleArtifact(ArtifactData artifactData, bool sellDrop, bool wholeStack, ulong ownerId = 0UL)
		{
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297C")]
		private void DismantleArtifactSuccessHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297D")]
		protected virtual void HandleSuccessDismantle(InventoryController.DismantleArtifactVO dismantleInformation)
		{
		}

		// Token: 0x0600297E RID: 10622
		[Token(Token = "0x600297E")]
		public abstract void MoveItemToChest(ArtifactData artifactData);

		// Token: 0x0600297F RID: 10623
		[Token(Token = "0x600297F")]
		public abstract void RequestMoveItemTo(ArtifactData artifact, int slotId);

		// Token: 0x06002980 RID: 10624
		[Token(Token = "0x6002980")]
		public abstract OpToken<IMessage, object> BuySlots(uint quantity);

		// Token: 0x06002981 RID: 10625
		[Token(Token = "0x6002981")]
		public abstract void SellItem(ArtifactData artifactData);

		// Token: 0x06002982 RID: 10626
		[Token(Token = "0x6002982")]
		public abstract void RepairArtifact(ResourceSet price, params uint[] slotIds);

		// Token: 0x06002983 RID: 10627
		[Token(Token = "0x6002983")]
		public abstract void ReforgeArtifact(ResourceSet price, uint slotId);

		// Token: 0x06002984 RID: 10628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002984")]
		public void ClearFresh()
		{
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002985")]
		public DialogWindow ShowNotAvailableSlotsWindow(int slotsCount)
		{
			return null;
		}

		// Token: 0x04001712 RID: 5906
		[Token(Token = "0x4001712")]
		[FieldOffset(Offset = "0x0")]
		private CraftService _craftService;

		// Token: 0x04001713 RID: 5907
		[Token(Token = "0x4001713")]
		[FieldOffset(Offset = "0x0")]
		protected CallAccumulator _inventoryChangedCall;

		// Token: 0x04001714 RID: 5908
		[Token(Token = "0x4001714")]
		[FieldOffset(Offset = "0x0")]
		public readonly InventoryActionsMiddlewareBase<M> MiddlewareActions;
	}
}
