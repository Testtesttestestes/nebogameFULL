using System;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Rating;

namespace Gameplay.Rating.Model
{
	// Token: 0x0200058F RID: 1423
	[Token(Token = "0x200058F")]
	public class RatingRequestDto
	{
		// Token: 0x06002214 RID: 8724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002214")]
		[Address(RVA = "0x7373", Offset = "0x7373", VA = "0x7373")]
		public RatingRequestDto(RatingKindTypeDic.Types.RatingKindType kindType, uint type, RatingPeriods period)
		{
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002215")]
		[Address(RVA = "0x7374", Offset = "0x7374", VA = "0x7374", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040012BB RID: 4795
		[Token(Token = "0x40012BB")]
		[FieldOffset(Offset = "0x8")]
		public readonly RatingKindTypeDic.Types.RatingKindType KindType;

		// Token: 0x040012BC RID: 4796
		[Token(Token = "0x40012BC")]
		[FieldOffset(Offset = "0xC")]
		public readonly uint Type;

		// Token: 0x040012BD RID: 4797
		[Token(Token = "0x40012BD")]
		[FieldOffset(Offset = "0x10")]
		public readonly RatingPeriods Period;
	}
}
