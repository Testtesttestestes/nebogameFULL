using System;
using Il2CppDummyDll;
using MVC;
using Protocol.SmallGames;

namespace Gameplay.SmallGames.Events
{
	// Token: 0x02000538 RID: 1336
	[Token(Token = "0x2000538")]
	public class SmallGamesEvents : AbstractMVCEvents
	{
		// Token: 0x06001FD6 RID: 8150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD6")]
		[Address(RVA = "0x713B", Offset = "0x713B", VA = "0x713B")]
		public SmallGamesEvents()
		{
		}

		// Token: 0x04001180 RID: 4480
		[Token(Token = "0x4001180")]
		[FieldOffset(Offset = "0x14")]
		public Action VisitRegisteredEvent;

		// Token: 0x04001181 RID: 4481
		[Token(Token = "0x4001181")]
		[FieldOffset(Offset = "0x18")]
		public Action<SlotMachineType> LastJackpotRequestedEvent;

		// Token: 0x04001182 RID: 4482
		[Token(Token = "0x4001182")]
		[FieldOffset(Offset = "0x1C")]
		public Action JackpotRequestedEvent;

		// Token: 0x04001183 RID: 4483
		[Token(Token = "0x4001183")]
		[FieldOffset(Offset = "0x20")]
		public Action<bool> WheelResultReceivedEvent;

		// Token: 0x04001184 RID: 4484
		[Token(Token = "0x4001184")]
		[FieldOffset(Offset = "0x24")]
		public Action FreeAttemptsRequestedEvent;

		// Token: 0x04001185 RID: 4485
		[Token(Token = "0x4001185")]
		[FieldOffset(Offset = "0x28")]
		public Action LastDropRequestedEvent;

		// Token: 0x04001186 RID: 4486
		[Token(Token = "0x4001186")]
		[FieldOffset(Offset = "0x2C")]
		public Action DailyBonusTakenEvent;

		// Token: 0x04001187 RID: 4487
		[Token(Token = "0x4001187")]
		[FieldOffset(Offset = "0x30")]
		public Action CanTakeAdditionalChangedEvent;

		// Token: 0x04001188 RID: 4488
		[Token(Token = "0x4001188")]
		[FieldOffset(Offset = "0x34")]
		public Action<int> RewardSlotMachineNotificationsCountChangedEvent;

		// Token: 0x04001189 RID: 4489
		[Token(Token = "0x4001189")]
		[FieldOffset(Offset = "0x38")]
		public Action<int> FreeAttemptsCountChanged;
	}
}
