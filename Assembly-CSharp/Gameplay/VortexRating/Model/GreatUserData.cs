using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Rating;

namespace Gameplay.VortexRating.Model
{
	// Token: 0x02000395 RID: 917
	[Token(Token = "0x2000395")]
	public class GreatUserData
	{
		// Token: 0x06001564 RID: 5476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001564")]
		[Address(RVA = "0x6726", Offset = "0x6726", VA = "0x6726")]
		public GreatUserData()
		{
		}

		// Token: 0x04000B5E RID: 2910
		[Token(Token = "0x4000B5E")]
		[FieldOffset(Offset = "0x8")]
		public GreatUserTopInfo UserTopInfo;

		// Token: 0x04000B5F RID: 2911
		[Token(Token = "0x4000B5F")]
		[FieldOffset(Offset = "0xC")]
		public AprDic AprDic;

		// Token: 0x04000B60 RID: 2912
		[Token(Token = "0x4000B60")]
		[FieldOffset(Offset = "0x10")]
		public RewardData[] Rewards;

		// Token: 0x04000B61 RID: 2913
		[Token(Token = "0x4000B61")]
		[FieldOffset(Offset = "0x14")]
		public bool Voted;
	}
}
