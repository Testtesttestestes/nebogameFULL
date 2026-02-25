using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;

namespace UI.Rewards.Renderers
{
	// Token: 0x020001A8 RID: 424
	[Token(Token = "0x20001A8")]
	public class ArtifactsStackableRewardRender : ArtifactRewardRender
	{
		// Token: 0x17000182 RID: 386
		// (set) Token: 0x06000B8E RID: 2958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000182")]
		public override RewardData Reward
		{
			[Token(Token = "0x6000B8E")]
			[Address(RVA = "0x5EA7", Offset = "0x5EA7", VA = "0x5EA7", Slot = "7")]
			protected set
			{
			}
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x5EA8", Offset = "0x5EA8", VA = "0x5EA8", Slot = "10")]
		protected override ArtikulData CreateArtikul(int index, uint artikulId)
		{
			return null;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x5EA9", Offset = "0x5EA9", VA = "0x5EA9")]
		public ArtifactsStackableRewardRender()
		{
		}

		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0x4C")]
		private List<long> _artifactCountsByIndex;
	}
}
