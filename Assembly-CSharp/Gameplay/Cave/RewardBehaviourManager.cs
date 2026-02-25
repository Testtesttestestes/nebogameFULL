using System;
using Il2CppDummyDll;
using Protocol.Common;

namespace Gameplay.Cave
{
	// Token: 0x02000B2C RID: 2860
	[Token(Token = "0x2000B2C")]
	public static class RewardBehaviourManager
	{
		// Token: 0x0600458F RID: 17807 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600458F")]
		[Address(RVA = "0x9433", Offset = "0x9433", VA = "0x9433")]
		public static CaveModel.RewardInCave GetReward(RewardInfo rewardInfo)
		{
			return null;
		}

		// Token: 0x04002609 RID: 9737
		[Token(Token = "0x4002609")]
		[FieldOffset(Offset = "0x0")]
		private static BaseRewardBehaviour[] _behavioursList;
	}
}
