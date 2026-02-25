using System;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Competition.Model
{
	// Token: 0x020008FA RID: 2298
	[Token(Token = "0x20008FA")]
	public class RewardsModel : AbstractModel
	{
		// Token: 0x06003618 RID: 13848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003618")]
		[Address(RVA = "0x8625", Offset = "0x8625", VA = "0x8625")]
		public RewardsModel(IDictProvider dictProvider, CompetitionData competition, UserData user)
		{
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003619")]
		[Address(RVA = "0x8626", Offset = "0x8626", VA = "0x8626")]
		public RatingPrizeDic[] GetRewards()
		{
			return null;
		}

		// Token: 0x04001DBE RID: 7614
		[Token(Token = "0x4001DBE")]
		[FieldOffset(Offset = "0xC")]
		public readonly CompetitionData Competition;

		// Token: 0x04001DBF RID: 7615
		[Token(Token = "0x4001DBF")]
		[FieldOffset(Offset = "0x10")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04001DC0 RID: 7616
		[Token(Token = "0x4001DC0")]
		[FieldOffset(Offset = "0x14")]
		private RatingPrizeDic[] _cachedRewards;
	}
}
