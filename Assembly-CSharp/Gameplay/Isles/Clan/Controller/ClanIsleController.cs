using System;
using Core.Gameplay;
using DG.Tweening;
using Gameplay.Isles.Base.Controller;
using Gameplay.Isles.Clan.Events;
using Gameplay.Isles.Clan.Model;
using Gameplay.World.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.ClanIsle;
using Protocol.Consts;
using ServicesNamespace;
using Utils;

namespace Gameplay.Isles.Clan.Controller
{
	// Token: 0x02000CF5 RID: 3317
	[Token(Token = "0x2000CF5")]
	public class ClanIsleController : BaseIsleController<ClanIsleModel, Gameplay.Isles.Clan.Events.ClanIsleEvents>
	{
		// Token: 0x060050B6 RID: 20662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B6")]
		[Address(RVA = "0x9EC5", Offset = "0x9EC5", VA = "0x9EC5")]
		public ClanIsleController(IGame game, ClanIsleModel model, Gameplay.Isles.Clan.Events.ClanIsleEvents events)
		{
		}

		// Token: 0x060050B7 RID: 20663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B7")]
		[Address(RVA = "0x9EC6", Offset = "0x9EC6", VA = "0x9EC6", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060050B8 RID: 20664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B8")]
		[Address(RVA = "0x9EC7", Offset = "0x9EC7", VA = "0x9EC7", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060050B9 RID: 20665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B9")]
		[Address(RVA = "0x9EC8", Offset = "0x9EC8", VA = "0x9EC8")]
		public void SetIsleInformation(ProtoGetIsleInfoAns.Types.ClanIsleInformation isleInformation)
		{
		}

		// Token: 0x060050BA RID: 20666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050BA")]
		[Address(RVA = "0x9EC9", Offset = "0x9EC9", VA = "0x9EC9")]
		public void StartBuild(BaseBuildingData clanBuildingData, ClanBuildingTypes type)
		{
		}

		// Token: 0x060050BB RID: 20667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050BB")]
		[Address(RVA = "0x9ECA", Offset = "0x9ECA", VA = "0x9ECA")]
		public void AccelerateBuild(BaseBuildingData data)
		{
		}

		// Token: 0x060050BC RID: 20668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050BC")]
		[Address(RVA = "0x9ECB", Offset = "0x9ECB", VA = "0x9ECB")]
		public void CancelBuild(ClanBuildingTypes typeId)
		{
		}

		// Token: 0x060050BD RID: 20669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050BD")]
		[Address(RVA = "0x9ECC", Offset = "0x9ECC", VA = "0x9ECC")]
		public void RepayCreditDebt()
		{
		}

		// Token: 0x060050BE RID: 20670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050BE")]
		[Address(RVA = "0x9ECD", Offset = "0x9ECD", VA = "0x9ECD")]
		private void StartBuildingServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060050BF RID: 20671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050BF")]
		[Address(RVA = "0x9ECE", Offset = "0x9ECE", VA = "0x9ECE")]
		private void AccelerateBuildServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C0")]
		[Address(RVA = "0x9ECF", Offset = "0x9ECF", VA = "0x9ECF")]
		private void CancelBuildServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060050C1 RID: 20673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C1")]
		[Address(RVA = "0x9ED0", Offset = "0x9ED0", VA = "0x9ED0")]
		private void RepayCreditDebtResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060050C2 RID: 20674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C2")]
		[Address(RVA = "0x9ED1", Offset = "0x9ED1", VA = "0x9ED1")]
		private void ClanIsleServiceOnGolemStateChangedEvent(ProtoGolemStateChangedEvt evt)
		{
		}

		// Token: 0x060050C3 RID: 20675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C3")]
		[Address(RVA = "0x9ED2", Offset = "0x9ED2", VA = "0x9ED2")]
		private void ClanIsleServiceOnBuildingCanceledEvent(ProtoBuildingCanceledEvt evt)
		{
		}

		// Token: 0x060050C4 RID: 20676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C4")]
		[Address(RVA = "0x9ED3", Offset = "0x9ED3", VA = "0x9ED3")]
		private void ClanIsleServiceOnBuildingAcceleratedEvent(ProtoBuildingAcceleratedEvt evt)
		{
		}

		// Token: 0x060050C5 RID: 20677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C5")]
		[Address(RVA = "0x9ED4", Offset = "0x9ED4", VA = "0x9ED4")]
		private void ClanIsleServiceOnBuildingStartedEvent(ProtoBuildingStartedEvt evt)
		{
		}

		// Token: 0x060050C6 RID: 20678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C6")]
		[Address(RVA = "0x9ED5", Offset = "0x9ED5", VA = "0x9ED5")]
		private void ClanIsleServiceOnBuildingFinishedEvent(ProtoBuildingFinishedEvt evt)
		{
		}

		// Token: 0x060050C7 RID: 20679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C7")]
		[Address(RVA = "0x9ED6", Offset = "0x9ED6", VA = "0x9ED6")]
		private void GoToClanIsle(ulong clanId)
		{
		}

		// Token: 0x060050C8 RID: 20680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C8")]
		[Address(RVA = "0x9ED7", Offset = "0x9ED7", VA = "0x9ED7")]
		private void GetClanIsleInfoServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060050C9 RID: 20681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C9")]
		[Address(RVA = "0x9ED8", Offset = "0x9ED8", VA = "0x9ED8")]
		private void RequestClanIsle()
		{
		}

		// Token: 0x04002C14 RID: 11284
		[Token(Token = "0x4002C14")]
		[FieldOffset(Offset = "0x18")]
		private readonly ClanIsleService _clanIsleService;

		// Token: 0x04002C15 RID: 11285
		[Token(Token = "0x4002C15")]
		[FieldOffset(Offset = "0x1C")]
		private readonly ClansService _clansService;

		// Token: 0x04002C16 RID: 11286
		[Token(Token = "0x4002C16")]
		[FieldOffset(Offset = "0x20")]
		private Tween _delayedCall;

		// Token: 0x04002C17 RID: 11287
		[Token(Token = "0x4002C17")]
		[FieldOffset(Offset = "0x24")]
		private readonly IGame _game;
	}
}
