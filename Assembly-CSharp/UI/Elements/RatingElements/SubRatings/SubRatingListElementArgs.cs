using System;
using Gameplay.Rating.Model;
using Il2CppDummyDll;
using UI.Elements.GenericList;

namespace UI.Elements.RatingElements.SubRatings
{
	// Token: 0x02000219 RID: 537
	[Token(Token = "0x2000219")]
	public class SubRatingListElementArgs : GenericListElementArgs
	{
		// Token: 0x06000D6A RID: 3434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6A")]
		[Address(RVA = "0x604D", Offset = "0x604D", VA = "0x604D")]
		public SubRatingListElementArgs(SubRatingInfo info)
		{
		}

		// Token: 0x040006AE RID: 1710
		[Token(Token = "0x40006AE")]
		[FieldOffset(Offset = "0xC")]
		public SubRatingInfo info;
	}
}
