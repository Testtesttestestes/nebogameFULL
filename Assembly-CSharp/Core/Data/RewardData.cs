using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Decorators;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Core.Data
{
	// Token: 0x020010C2 RID: 4290
	[Token(Token = "0x20010C2")]
	public class RewardData
	{
		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x0600643C RID: 25660 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700142E")]
		public IRewardInfo RewardInfo
		{
			[Token(Token = "0x600643C")]
			[Address(RVA = "0x1C3A", Offset = "0x1C3A", VA = "0x1C3A")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x0600643D RID: 25661 RVA: 0x00013068 File Offset: 0x00011268
		[Token(Token = "0x1700142F")]
		public uint RewardId
		{
			[Token(Token = "0x600643D")]
			[Address(RVA = "0x1F67", Offset = "0x1F67", VA = "0x1F67")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x0600643E RID: 25662 RVA: 0x00013080 File Offset: 0x00011280
		[Token(Token = "0x17001430")]
		public uint SortIndex
		{
			[Token(Token = "0x600643E")]
			[Address(RVA = "0xB030", Offset = "0xB030", VA = "0xB030")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x0600643F RID: 25663 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006440 RID: 25664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001431")]
		public List<object> CustomParams
		{
			[Token(Token = "0x600643F")]
			[Address(RVA = "0xB031", Offset = "0xB031", VA = "0xB031")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006440")]
			[Address(RVA = "0xB032", Offset = "0xB032", VA = "0xB032")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006441 RID: 25665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006441")]
		[Address(RVA = "0xB033", Offset = "0xB033", VA = "0xB033")]
		public RewardData(List<IRewardInfo> rewardInfoList)
		{
		}

		// Token: 0x06006442 RID: 25666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006442")]
		[Address(RVA = "0xB034", Offset = "0xB034", VA = "0xB034")]
		public RewardData()
		{
		}

		// Token: 0x06006443 RID: 25667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006443")]
		[Address(RVA = "0xB035", Offset = "0xB035", VA = "0xB035")]
		public static RewardData Create(RewardTypes id)
		{
			return null;
		}

		// Token: 0x0400358A RID: 13706
		[Token(Token = "0x400358A")]
		[FieldOffset(Offset = "0x8")]
		public readonly List<IRewardInfo> RewardInfoList;
	}
}
