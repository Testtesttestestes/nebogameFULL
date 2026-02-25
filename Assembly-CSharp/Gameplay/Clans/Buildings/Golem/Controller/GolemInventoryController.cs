using System;
using Core.Data;
using Gameplay.Clans.Buildings.Golem.Events;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Inventory.Controller;
using Gameplay.Inventory.Controller.Middlewares;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Buildings.Golem.Controller
{
	// Token: 0x02000ADF RID: 2783
	[Token(Token = "0x2000ADF")]
	public class GolemInventoryController : InventoryBaseController<GolemInventoryModel, GolemInventoryEvents>
	{
		// Token: 0x0600430C RID: 17164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430C")]
		[Address(RVA = "0x91C0", Offset = "0x91C0", VA = "0x91C0")]
		public GolemInventoryController(GolemInventoryModel model, GolemInventoryEvents events, InventoryActionsMiddlewareBase<GolemInventoryModel> middlewareActions, ClansService clanService, ServicesService servicesService, CraftService craftService)
		{
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430D")]
		[Address(RVA = "0x91C1", Offset = "0x91C1", VA = "0x91C1")]
		private void RequestGolemArtifacts()
		{
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430E")]
		[Address(RVA = "0x91C2", Offset = "0x91C2", VA = "0x91C2")]
		private void GetGolemArtifactsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430F")]
		[Address(RVA = "0x91C3", Offset = "0x91C3", VA = "0x91C3", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06004310 RID: 17168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004310")]
		[Address(RVA = "0x91C4", Offset = "0x91C4", VA = "0x91C4", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004311")]
		[Address(RVA = "0x91C5", Offset = "0x91C5", VA = "0x91C5")]
		private void GolemSlotsChangedEventHandler(ProtoStackableChangesAns evt)
		{
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004312")]
		[Address(RVA = "0x91C6", Offset = "0x91C6", VA = "0x91C6", Slot = "16")]
		public override void RequestMoveItemTo(ArtifactData artifact, int slotId)
		{
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004313")]
		[Address(RVA = "0x91C7", Offset = "0x91C7", VA = "0x91C7", Slot = "17")]
		public override OpToken<IMessage, object> BuySlots(uint quantity)
		{
			return null;
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004314")]
		[Address(RVA = "0x91C8", Offset = "0x91C8", VA = "0x91C8")]
		protected void BuySlotHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004315")]
		[Address(RVA = "0x91C9", Offset = "0x91C9", VA = "0x91C9")]
		protected void SwapSlotsSuccessHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004316")]
		[Address(RVA = "0x91CA", Offset = "0x91CA", VA = "0x91CA")]
		private void PutUserItemToGolem(ArtifactData artifactData, int chestSlot)
		{
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004317")]
		[Address(RVA = "0x91CB", Offset = "0x91CB", VA = "0x91CB")]
		private void PutUserItemToGolemResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004318")]
		[Address(RVA = "0x91CC", Offset = "0x91CC", VA = "0x91CC", Slot = "15")]
		public override void MoveItemToChest(ArtifactData artifactData)
		{
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004319")]
		[Address(RVA = "0x91CD", Offset = "0x91CD", VA = "0x91CD", Slot = "18")]
		public override void SellItem(ArtifactData artifactData)
		{
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600431A")]
		[Address(RVA = "0x91CE", Offset = "0x91CE", VA = "0x91CE")]
		private void SellArtifactSuccessHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600431B")]
		[Address(RVA = "0x91CF", Offset = "0x91CF", VA = "0x91CF", Slot = "19")]
		public override void RepairArtifact(ResourceSet price, params uint[] slotIds)
		{
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600431C")]
		[Address(RVA = "0x91D0", Offset = "0x91D0", VA = "0x91D0", Slot = "20")]
		public override void ReforgeArtifact(ResourceSet price, uint slotId)
		{
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600431D")]
		[Address(RVA = "0x91D1", Offset = "0x91D1", VA = "0x91D1", Slot = "13")]
		public override void DismantleArtifact(ArtifactData artifactData, bool sellDrop = false, bool wholeStack = false)
		{
		}

		// Token: 0x040024F7 RID: 9463
		[Token(Token = "0x40024F7")]
		[FieldOffset(Offset = "0x24")]
		private ClansService _clansService;

		// Token: 0x040024F8 RID: 9464
		[Token(Token = "0x40024F8")]
		[FieldOffset(Offset = "0x28")]
		private ServicesService _servicesService;
	}
}
