using System;
using Core;
using Gameplay.Competition.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Events
{
	// Token: 0x020008FE RID: 2302
	[Token(Token = "0x20008FE")]
	public class CompetitionEvents : AbstractMVCEvents
	{
		// Token: 0x06003621 RID: 13857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003621")]
		[Address(RVA = "0x862E", Offset = "0x862E", VA = "0x862E")]
		public CompetitionEvents()
		{
		}

		// Token: 0x04001DCC RID: 7628
		[Token(Token = "0x4001DCC")]
		[FieldOffset(Offset = "0x14")]
		public Action<CompetitionData> StateChangedEvent;

		// Token: 0x04001DCD RID: 7629
		[Token(Token = "0x4001DCD")]
		[FieldOffset(Offset = "0x18")]
		public ChangedFromTo<OwnerRating> OwnerRatingChangedEvent;

		// Token: 0x04001DCE RID: 7630
		[Token(Token = "0x4001DCE")]
		[FieldOffset(Offset = "0x1C")]
		public Action RatingChangedEvent;

		// Token: 0x04001DCF RID: 7631
		[Token(Token = "0x4001DCF")]
		[FieldOffset(Offset = "0x20")]
		public Action QuestsChangedEvent;

		// Token: 0x04001DD0 RID: 7632
		[Token(Token = "0x4001DD0")]
		[FieldOffset(Offset = "0x24")]
		public Action ActiveQuestsCountChangedEvent;

		// Token: 0x04001DD1 RID: 7633
		[Token(Token = "0x4001DD1")]
		[FieldOffset(Offset = "0x28")]
		public Action QuestsUpdatedEvent;
	}
}
