using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Rating.Model
{
	// Token: 0x0200058A RID: 1418
	[Token(Token = "0x200058A")]
	public class RatingInfo
	{
		// Token: 0x060021D3 RID: 8659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D3")]
		[Address(RVA = "0x7332", Offset = "0x7332", VA = "0x7332")]
		public RatingInfo(RepeatedField<UserRatingKindDic> subRatings)
		{
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D4")]
		[Address(RVA = "0x7333", Offset = "0x7333", VA = "0x7333")]
		public RatingInfo(RepeatedField<ClanRatingKindDic> subRatings)
		{
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D5")]
		[Address(RVA = "0x7334", Offset = "0x7334", VA = "0x7334")]
		public RatingInfo(RepeatedField<CultRatingKindDic> subRatings)
		{
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D6")]
		[Address(RVA = "0x7335", Offset = "0x7335", VA = "0x7335")]
		public RatingInfo(RatingKindTypeDic.Types.RatingKindType specId, string title, Dictionary<uint, SubRatingInfo> subRatings)
		{
		}

		// Token: 0x04001296 RID: 4758
		[Token(Token = "0x4001296")]
		[FieldOffset(Offset = "0x8")]
		public readonly RatingKindTypeDic.Types.RatingKindType SpecId;

		// Token: 0x04001297 RID: 4759
		[Token(Token = "0x4001297")]
		[FieldOffset(Offset = "0xC")]
		public readonly string Title;

		// Token: 0x04001298 RID: 4760
		[Token(Token = "0x4001298")]
		[FieldOffset(Offset = "0x10")]
		public readonly Dictionary<uint, SubRatingInfo> SubRatings;
	}
}
