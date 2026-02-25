using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Main;

namespace Gameplay.GdEvents.Model
{
	// Token: 0x02000753 RID: 1875
	[Token(Token = "0x2000753")]
	public class RewardProvider : IRewardProvider
	{
		// Token: 0x06002CC3 RID: 11459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC3")]
		[Address(RVA = "0x7D4A", Offset = "0x7D4A", VA = "0x7D4A", Slot = "4")]
		public void Clear()
		{
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC4")]
		[Address(RVA = "0x7D4B", Offset = "0x7D4B", VA = "0x7D4B", Slot = "5")]
		public void SetReward(uint evtId, RewardInfo[] rewards)
		{
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC5")]
		[Address(RVA = "0x7D4C", Offset = "0x7D4C", VA = "0x7D4C", Slot = "6")]
		public void SetReward(uint evtId, ProtoGetEventMilestonesRewardsInfoAns.Types.MilestoneRewards rewards)
		{
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x000088B0 File Offset: 0x00006AB0
		[Token(Token = "0x6002CC6")]
		[Address(RVA = "0x7D4D", Offset = "0x7D4D", VA = "0x7D4D", Slot = "7")]
		public bool TryGetReward(uint evtId, out RewardInfo[] rewards)
		{
			return default(bool);
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x000088C8 File Offset: 0x00006AC8
		[Token(Token = "0x6002CC7")]
		[Address(RVA = "0x7D4E", Offset = "0x7D4E", VA = "0x7D4E", Slot = "8")]
		public bool TryGetReward(uint evtId, uint milestoneNumber, out ProtoGetEventMilestonesRewardsInfoAns.Types.MilestoneRewards rewards)
		{
			return default(bool);
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC8")]
		[Address(RVA = "0x7D4F", Offset = "0x7D4F", VA = "0x7D4F")]
		public RewardProvider()
		{
		}

		// Token: 0x04001898 RID: 6296
		[Token(Token = "0x4001898")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<uint, RewardInfo[]> _eventRewards;

		// Token: 0x04001899 RID: 6297
		[Token(Token = "0x4001899")]
		[FieldOffset(Offset = "0xC")]
		private readonly Dictionary<uint, List<ProtoGetEventMilestonesRewardsInfoAns.Types.MilestoneRewards>> _milestoneRewards;
	}
}
