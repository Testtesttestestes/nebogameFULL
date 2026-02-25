using System;
using Gameplay.ArtifactDrop.Model;
using Gameplay.SmallGames.Events;
using Gameplay.SmallGames.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;
using Protocol.SmallGames;
using ServicesNamespace;
using Utils;

namespace Gameplay.SmallGames.Controller
{
	// Token: 0x0200053A RID: 1338
	[Token(Token = "0x200053A")]
	public class SmallGamesController : AbstractController<SmallGamesModel, Gameplay.SmallGames.Events.SmallGamesEvents>
	{
		// Token: 0x06001FE9 RID: 8169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE9")]
		[Address(RVA = "0x714E", Offset = "0x714E", VA = "0x714E", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEA")]
		[Address(RVA = "0x714F", Offset = "0x714F", VA = "0x714F")]
		public SmallGamesController(SmallGamesModel model, Gameplay.SmallGames.Events.SmallGamesEvents events)
		{
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEB")]
		[Address(RVA = "0x7150", Offset = "0x7150", VA = "0x7150")]
		public void RequestLastDrop()
		{
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEC")]
		[Address(RVA = "0x7151", Offset = "0x7151", VA = "0x7151")]
		private void RequestLastDropResultHandler(ArtifactDropModel.ArtifactDrop drop)
		{
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FED")]
		[Address(RVA = "0x7152", Offset = "0x7152", VA = "0x7152")]
		public void TakeAllDrop()
		{
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEE")]
		[Address(RVA = "0x7153", Offset = "0x7153", VA = "0x7153")]
		private void DropRemovedEventHandler(DropTypes obj)
		{
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEF")]
		[Address(RVA = "0x7154", Offset = "0x7154", VA = "0x7154")]
		public void SellAllDrop()
		{
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF0")]
		[Address(RVA = "0x7155", Offset = "0x7155", VA = "0x7155")]
		public void RegisterVisit()
		{
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF1")]
		[Address(RVA = "0x7156", Offset = "0x7156", VA = "0x7156")]
		private void SmallGamesServiceOnRewardChangedEvent(ProtoRewardChangedEvt evt)
		{
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF2")]
		[Address(RVA = "0x7157", Offset = "0x7157", VA = "0x7157")]
		private void SmallGamesServiceOnAdditionalRewardChangedEvent(ProtoAdditionalRewardChangedEvt e)
		{
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF3")]
		[Address(RVA = "0x7158", Offset = "0x7158", VA = "0x7158")]
		private void HandleRegisterVisit(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF4")]
		[Address(RVA = "0x7159", Offset = "0x7159", VA = "0x7159")]
		public void GetLastJackpotInfos()
		{
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF5")]
		[Address(RVA = "0x715A", Offset = "0x715A", VA = "0x715A")]
		private void GetLastJackpotInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF6")]
		[Address(RVA = "0x715B", Offset = "0x715B", VA = "0x715B")]
		public void GetJackpotInfo()
		{
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF7")]
		[Address(RVA = "0x715C", Offset = "0x715C", VA = "0x715C")]
		private void GetJackpotInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF8")]
		[Address(RVA = "0x715D", Offset = "0x715D", VA = "0x715D")]
		public void LaunchWheel(SlotMachineType slotMachineType, uint scrollCount)
		{
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF9")]
		[Address(RVA = "0x715E", Offset = "0x715E", VA = "0x715E")]
		private void LaunchWheelResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFA")]
		[Address(RVA = "0x715F", Offset = "0x715F", VA = "0x715F")]
		public void GetFreeAttempts()
		{
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFB")]
		[Address(RVA = "0x7160", Offset = "0x7160", VA = "0x7160")]
		public void GetFreeAttempts(SlotMachineType type)
		{
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFC")]
		[Address(RVA = "0x7161", Offset = "0x7161", VA = "0x7161")]
		private void GetFreeAttemptsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFD")]
		[Address(RVA = "0x7162", Offset = "0x7162", VA = "0x7162")]
		private void SetFreeAttempts(FreeAttemptsInfo freeAttempts, SlotMachineType type)
		{
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFE")]
		[Address(RVA = "0x7163", Offset = "0x7163", VA = "0x7163")]
		public void TakeDailyBonus()
		{
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFF")]
		[Address(RVA = "0x7164", Offset = "0x7164", VA = "0x7164")]
		private void TakeDailyBonusResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002000")]
		[Address(RVA = "0x7165", Offset = "0x7165", VA = "0x7165", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002001")]
		[Address(RVA = "0x7166", Offset = "0x7166", VA = "0x7166", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002002")]
		[Address(RVA = "0x7167", Offset = "0x7167", VA = "0x7167")]
		private void ValidateInit()
		{
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002003")]
		[Address(RVA = "0x7168", Offset = "0x7168", VA = "0x7168")]
		public void CheckIfNotificationsNeedToUpdate()
		{
		}

		// Token: 0x0400118F RID: 4495
		[Token(Token = "0x400118F")]
		[FieldOffset(Offset = "0x18")]
		private SmallGamesService _smallGamesService;
	}
}
