using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Utils
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public static class ResourceRewardsUtils
	{
		// Token: 0x060002DA RID: 730 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x5756", Offset = "0x5756", VA = "0x5756")]
		private static Dictionary<RewardTypes, Resources> GetRewardToResourceDict()
		{
			return null;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x5757", Offset = "0x5757", VA = "0x5757")]
		public static RewardTypes? GetRewardTypes(Resources resource)
		{
			return null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x5758", Offset = "0x5758", VA = "0x5758")]
		public static Resources? GetResources(RewardTypes reward)
		{
			return null;
		}

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Resources, RewardTypes> _resourceToRewardDict;
	}
}
