using System;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Main;

namespace Gameplay.GdEvents.Model
{
	// Token: 0x02000751 RID: 1873
	[Token(Token = "0x2000751")]
	public interface IRewardProvider
	{
		// Token: 0x06002CBD RID: 11453
		[Token(Token = "0x6002CBD")]
		void Clear();

		// Token: 0x06002CBE RID: 11454
		[Token(Token = "0x6002CBE")]
		void SetReward(uint evtId, RewardInfo[] rewards);

		// Token: 0x06002CBF RID: 11455
		[Token(Token = "0x6002CBF")]
		void SetReward(uint evtId, ProtoGetEventMilestonesRewardsInfoAns.Types.MilestoneRewards rewards);

		// Token: 0x06002CC0 RID: 11456
		[Token(Token = "0x6002CC0")]
		bool TryGetReward(uint evtId, out RewardInfo[] rewards);

		// Token: 0x06002CC1 RID: 11457
		[Token(Token = "0x6002CC1")]
		bool TryGetReward(uint evtId, uint milestoneNumber, out ProtoGetEventMilestonesRewardsInfoAns.Types.MilestoneRewards rewards);
	}
}
