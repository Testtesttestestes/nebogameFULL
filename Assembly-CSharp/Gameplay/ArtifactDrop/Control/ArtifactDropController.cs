using System;
using Core.Data;
using Gameplay.ArtifactDrop.Model;
using Gameplay.Inventory.Controller.Middlewares;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.ArtifactDrop.Control
{
	// Token: 0x02000CCA RID: 3274
	[Token(Token = "0x2000CCA")]
	public class ArtifactDropController : AbstractController<ArtifactDropModel, ArtifactDropEvents>, IArtifactDrop
	{
		// Token: 0x06004FAF RID: 20399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FAF")]
		[Address(RVA = "0x9DC8", Offset = "0x9DC8", VA = "0x9DC8", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06004FB0 RID: 20400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB0")]
		[Address(RVA = "0x9DC9", Offset = "0x9DC9", VA = "0x9DC9")]
		public ArtifactDropController(MainService mainService, CraftService craftService, DismantleMiddleware dismantleMiddleware, ArtifactDropModel model, ArtifactDropEvents events)
		{
		}

		// Token: 0x06004FB1 RID: 20401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB1")]
		[Address(RVA = "0x9DCA", Offset = "0x9DCA", VA = "0x9DCA", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06004FB2 RID: 20402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB2")]
		[Address(RVA = "0x9DCB", Offset = "0x9DCB", VA = "0x9DCB", Slot = "12")]
		public void Remove(DropTypes dropType)
		{
		}

		// Token: 0x06004FB3 RID: 20403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB3")]
		[Address(RVA = "0x9DCC", Offset = "0x9DCC", VA = "0x9DCC", Slot = "13")]
		public void Remove(ArtifactData[] artifacts)
		{
		}

		// Token: 0x06004FB4 RID: 20404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB4")]
		[Address(RVA = "0x9DCD", Offset = "0x9DCD", VA = "0x9DCD", Slot = "14")]
		public void Remove(ArtifactData artifact)
		{
		}

		// Token: 0x06004FB5 RID: 20405 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		[Token(Token = "0x6004FB5")]
		[Address(RVA = "0x9DCE", Offset = "0x9DCE", VA = "0x9DCE", Slot = "16")]
		public bool TryGetDrop(DropTypes dropType, out ArtifactDropModel.ArtifactDrop drop)
		{
			return default(bool);
		}

		// Token: 0x06004FB6 RID: 20406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB6")]
		[Address(RVA = "0x9DCF", Offset = "0x9DCF", VA = "0x9DCF", Slot = "15")]
		public void SetDrop(DropTypes dropType, params ArtifactInfo[] artifactInfo)
		{
		}

		// Token: 0x06004FB7 RID: 20407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB7")]
		[Address(RVA = "0x9DD0", Offset = "0x9DD0", VA = "0x9DD0")]
		private void SetDrop(ArtifactDropModel.ArtifactDrop drop)
		{
		}

		// Token: 0x06004FB8 RID: 20408 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004FB8")]
		[Address(RVA = "0x9DD1", Offset = "0x9DD1", VA = "0x9DD1")]
		private ArtifactDropModel.ArtifactDrop CreateArtifactDrop(DropTypes dropType, ProtoGetLastDropAns msg)
		{
			return null;
		}

		// Token: 0x06004FB9 RID: 20409 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004FB9")]
		[Address(RVA = "0x9DD2", Offset = "0x9DD2", VA = "0x9DD2")]
		private ArtifactDropModel.ArtifactDrop CreateArtifactDrop(DropTypes dropType, ArtifactInfo[] artifactInfos, bool limitExceeded)
		{
			return null;
		}

		// Token: 0x06004FBA RID: 20410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBA")]
		[Address(RVA = "0x9DD3", Offset = "0x9DD3", VA = "0x9DD3")]
		private void Add(ArtifactDropModel.ArtifactDrop drop, params ArtifactInfo[] artifactInfos)
		{
		}

		// Token: 0x06004FBB RID: 20411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBB")]
		[Address(RVA = "0x9DD4", Offset = "0x9DD4", VA = "0x9DD4")]
		public void RequestDrop(DropTypes dropType)
		{
		}

		// Token: 0x06004FBC RID: 20412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBC")]
		[Address(RVA = "0x9DD5", Offset = "0x9DD5", VA = "0x9DD5")]
		public void RequestDrop(DropTypes dropType, ArtifactInfo[] artifactInfos)
		{
		}

		// Token: 0x06004FBD RID: 20413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBD")]
		[Address(RVA = "0x9DD6", Offset = "0x9DD6", VA = "0x9DD6")]
		public void TakeAllDrop(DropTypes dropType)
		{
		}

		// Token: 0x06004FBE RID: 20414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBE")]
		[Address(RVA = "0x9DD7", Offset = "0x9DD7", VA = "0x9DD7")]
		public void SellAllDrop(DropTypes dropType)
		{
		}

		// Token: 0x06004FBF RID: 20415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBF")]
		[Address(RVA = "0x9DD8", Offset = "0x9DD8", VA = "0x9DD8")]
		public void SellArtifacts(params ArtifactData[] artifacts)
		{
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC0")]
		[Address(RVA = "0x9DD9", Offset = "0x9DD9", VA = "0x9DD9")]
		public void TakeArtifacts(params ArtifactData[] artifacts)
		{
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC1")]
		[Address(RVA = "0x9DDA", Offset = "0x9DDA", VA = "0x9DDA")]
		public void EquipArtifact(ArtifactData artifact)
		{
		}

		// Token: 0x06004FC2 RID: 20418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC2")]
		[Address(RVA = "0x9DDB", Offset = "0x9DDB", VA = "0x9DDB")]
		public void DismantleArtifact(ArtifactData artifact, bool sellDrop, bool wholeStack)
		{
		}

		// Token: 0x06004FC3 RID: 20419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC3")]
		[Address(RVA = "0x9DDC", Offset = "0x9DDC", VA = "0x9DDC")]
		public void RequestGetLastDrop(DropTypes dropType)
		{
		}

		// Token: 0x06004FC4 RID: 20420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC4")]
		[Address(RVA = "0x9DDD", Offset = "0x9DDD", VA = "0x9DDD")]
		private void RequestTakeAllDrop(DropTypes dropType)
		{
		}

		// Token: 0x06004FC5 RID: 20421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC5")]
		[Address(RVA = "0x9DDE", Offset = "0x9DDE", VA = "0x9DDE")]
		private void RequestSellAllFromDrop(DropTypes dropType)
		{
		}

		// Token: 0x06004FC6 RID: 20422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC6")]
		[Address(RVA = "0x9DDF", Offset = "0x9DDF", VA = "0x9DDF")]
		private void RequestSellArtifactsFromDrop(params ArtifactData[] artifacts)
		{
		}

		// Token: 0x06004FC7 RID: 20423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC7")]
		[Address(RVA = "0x9DE0", Offset = "0x9DE0", VA = "0x9DE0")]
		private void RequestTakeArtifactFromDrop(DropTypes dropType, uint startSlotId, params ArtifactData[] artifacts)
		{
		}

		// Token: 0x06004FC8 RID: 20424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC8")]
		[Address(RVA = "0x9DE1", Offset = "0x9DE1", VA = "0x9DE1")]
		private void RequestDismantleArtifactFromDrop(ArtifactData artifactData, bool sellDrop, bool wholeStack)
		{
		}

		// Token: 0x06004FC9 RID: 20425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC9")]
		[Address(RVA = "0x9DE2", Offset = "0x9DE2", VA = "0x9DE2")]
		private void HandleDismantleArtifactFromDropService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004FCA RID: 20426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FCA")]
		[Address(RVA = "0x9DE3", Offset = "0x9DE3", VA = "0x9DE3")]
		private void HandleTakeArtifactFromDropService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004FCB RID: 20427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FCB")]
		[Address(RVA = "0x9DE4", Offset = "0x9DE4", VA = "0x9DE4")]
		private void HandleSellArtifactFromDropService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004FCC RID: 20428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FCC")]
		[Address(RVA = "0x9DE5", Offset = "0x9DE5", VA = "0x9DE5")]
		private void HandleSellAllFromDropService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FCD")]
		[Address(RVA = "0x9DE6", Offset = "0x9DE6", VA = "0x9DE6")]
		private void HandleTakeAllDropService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FCE")]
		[Address(RVA = "0x9DE7", Offset = "0x9DE7", VA = "0x9DE7")]
		private void HandleGetLastDropService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x04002B6B RID: 11115
		[Token(Token = "0x4002B6B")]
		[FieldOffset(Offset = "0x18")]
		private MainService _mainService;

		// Token: 0x04002B6C RID: 11116
		[Token(Token = "0x4002B6C")]
		[FieldOffset(Offset = "0x1C")]
		private CraftService _craftService;

		// Token: 0x04002B6D RID: 11117
		[Token(Token = "0x4002B6D")]
		[FieldOffset(Offset = "0x20")]
		private DismantleMiddleware _dismantleMiddleware;
	}
}
