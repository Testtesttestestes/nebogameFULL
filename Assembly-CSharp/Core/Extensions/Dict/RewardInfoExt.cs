using System;
using System.Collections.Generic;
using Core.Data;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F9F RID: 3999
	[Token(Token = "0x2000F9F")]
	public static class RewardInfoExt
	{
		// Token: 0x06005FD6 RID: 24534 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FD6")]
		[Address(RVA = "0xAC0D", Offset = "0xAC0D", VA = "0xAC0D")]
		public static ResourceSet ExtractResourceSet(this RewardInfo rewardInfo)
		{
			return null;
		}

		// Token: 0x06005FD7 RID: 24535 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FD7")]
		[Address(RVA = "0xAC0E", Offset = "0xAC0E", VA = "0xAC0E")]
		public static RewardData ToRewardData(this RewardInfo rewardInfo)
		{
			return null;
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x06005FD8 RID: 24536 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012D1")]
		private static HashSet<RewardTypes> AllGroupedRewardTypes
		{
			[Token(Token = "0x6005FD8")]
			[Address(RVA = "0xAC0F", Offset = "0xAC0F", VA = "0xAC0F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005FD9 RID: 24537 RVA: 0x00011928 File Offset: 0x0000FB28
		[Token(Token = "0x6005FD9")]
		[Address(RVA = "0xAC10", Offset = "0xAC10", VA = "0xAC10")]
		private static int GetGroupIndex(RewardTypes rewardType)
		{
			return 0;
		}

		// Token: 0x06005FDA RID: 24538 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FDA")]
		[Address(RVA = "0xAC11", Offset = "0xAC11", VA = "0xAC11")]
		public static RewardData[] ToRewardDataArray(this IList<RewardInfo> rewards)
		{
			return null;
		}

		// Token: 0x06005FDB RID: 24539 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FDB")]
		[Address(RVA = "0xAC12", Offset = "0xAC12", VA = "0xAC12")]
		public static RewardInfo GetRewardInfoByType(this RepeatedField<RewardInfo> rewards, RewardTypes rewardType)
		{
			return null;
		}

		// Token: 0x04003339 RID: 13113
		[Token(Token = "0x4003339")]
		[FieldOffset(Offset = "0x0")]
		public static List<HashSet<RewardTypes>> RewardInfoSetGroups;

		// Token: 0x0400333A RID: 13114
		[Token(Token = "0x400333A")]
		[FieldOffset(Offset = "0x4")]
		private static HashSet<RewardTypes> _allGroupedRewardTypes;
	}
}
