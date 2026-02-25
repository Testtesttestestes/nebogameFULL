using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Dic;

namespace Gameplay.Medals.Model
{
	// Token: 0x02000604 RID: 1540
	[Token(Token = "0x2000604")]
	public static class MedalUtils
	{
		// Token: 0x0600255B RID: 9563 RVA: 0x000071E8 File Offset: 0x000053E8
		[Token(Token = "0x600255B")]
		[Address(RVA = "0x1C2E", Offset = "0x1C2E", VA = "0x1C2E")]
		public static bool IsMedalHasRewardsWithSkills(MedalDic medalDic, List<int> skillIndexes)
		{
			return default(bool);
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x00007200 File Offset: 0x00005400
		[Token(Token = "0x600255C")]
		[Address(RVA = "0x76A2", Offset = "0x76A2", VA = "0x76A2")]
		public static bool IsMedalHasRewardsOtherThanSkills(MedalDic md)
		{
			return default(bool);
		}

		// Token: 0x04001476 RID: 5238
		[Token(Token = "0x4001476")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<RewardTypes> SkillRewardTypes;
	}
}
