using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Data.Decorators
{
	// Token: 0x020010EE RID: 4334
	[Token(Token = "0x20010EE")]
	public class RewardInfoDecorator : IRewardInfo
	{
		// Token: 0x0600654D RID: 25933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600654D")]
		[Address(RVA = "0xB116", Offset = "0xB116", VA = "0xB116")]
		public RewardInfoDecorator(RewardInfo rewardInfo)
		{
		}

		// Token: 0x0600654E RID: 25934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600654E")]
		[Address(RVA = "0xB117", Offset = "0xB117", VA = "0xB117")]
		public RewardInfoDecorator(uint rewardId)
		{
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x0600654F RID: 25935 RVA: 0x00013488 File Offset: 0x00011688
		[Token(Token = "0x17001489")]
		public uint RewardId
		{
			[Token(Token = "0x600654F")]
			[Address(RVA = "0xB118", Offset = "0xB118", VA = "0xB118", Slot = "4")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x06006550 RID: 25936 RVA: 0x000134A0 File Offset: 0x000116A0
		[Token(Token = "0x1700148A")]
		public uint SortIndex
		{
			[Token(Token = "0x6006550")]
			[Address(RVA = "0xB119", Offset = "0xB119", VA = "0xB119", Slot = "5")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x06006551 RID: 25937 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006552 RID: 25938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700148B")]
		public IList<long> Params
		{
			[Token(Token = "0x6006551")]
			[Address(RVA = "0xB11A", Offset = "0xB11A", VA = "0xB11A", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006552")]
			[Address(RVA = "0xB11B", Offset = "0xB11B", VA = "0xB11B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x04003628 RID: 13864
		[Token(Token = "0x4003628")]
		[FieldOffset(Offset = "0x8")]
		private RewardInfo _rewardInfo;
	}
}
