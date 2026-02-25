using System;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Rating;
using ServicesNamespace;
using Utils;

namespace Gameplay.Competition.Control.Sections
{
	// Token: 0x0200090A RID: 2314
	[Token(Token = "0x200090A")]
	public class RatingController : AbstractController<RatingModel, Gameplay.Competition.Events.RatingEvents>
	{
		// Token: 0x06003664 RID: 13924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003664")]
		[Address(RVA = "0x8671", Offset = "0x8671", VA = "0x8671")]
		public RatingController(RatingService ratingService, RatingModel model, Gameplay.Competition.Events.RatingEvents events)
		{
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003665")]
		[Address(RVA = "0x8672", Offset = "0x8672", VA = "0x8672", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003666")]
		[Address(RVA = "0x8673", Offset = "0x8673", VA = "0x8673")]
		private void ValidateInit()
		{
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003667")]
		[Address(RVA = "0x8674", Offset = "0x8674", VA = "0x8674")]
		public void RequestRating()
		{
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003668")]
		[Address(RVA = "0x8675", Offset = "0x8675", VA = "0x8675")]
		private void HandleGetAllCompetitionRatingService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003669")]
		[Address(RVA = "0x8676", Offset = "0x8676", VA = "0x8676")]
		private void SetRating(RepeatedField<UserInCompetitionRating> ratings)
		{
		}

		// Token: 0x04001DDD RID: 7645
		[Token(Token = "0x4001DDD")]
		[FieldOffset(Offset = "0x18")]
		private readonly RatingService _ratingService;
	}
}
