using System;
using Gameplay.Rating.Events;
using Gameplay.Rating.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Rating.Control
{
	// Token: 0x0200059B RID: 1435
	[Token(Token = "0x200059B")]
	public class RatingController : AbstractController<RatingModel, RatingEvents>
	{
		// Token: 0x06002263 RID: 8803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002263")]
		[Address(RVA = "0x73BA", Offset = "0x73BA", VA = "0x73BA")]
		public RatingController(RatingModel model, RatingEvents events)
		{
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002264")]
		[Address(RVA = "0x73BB", Offset = "0x73BB", VA = "0x73BB")]
		public void RequestUsersRating(RatingRequestDto ratingRequest)
		{
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002265")]
		[Address(RVA = "0x73BC", Offset = "0x73BC", VA = "0x73BC")]
		private void GetUsersRatingResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002266")]
		[Address(RVA = "0x73BD", Offset = "0x73BD", VA = "0x73BD")]
		public void RequestClansRating(RatingRequestDto ratingRequest)
		{
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002267")]
		[Address(RVA = "0x73BE", Offset = "0x73BE", VA = "0x73BE")]
		private void GetClansRatingResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002268")]
		[Address(RVA = "0x73BF", Offset = "0x73BF", VA = "0x73BF")]
		public void RequestCultsRating(RatingRequestDto ratingRequest)
		{
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002269")]
		[Address(RVA = "0x73C0", Offset = "0x73C0", VA = "0x73C0")]
		private void GetCultsRatingResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x040012D5 RID: 4821
		[Token(Token = "0x40012D5")]
		[FieldOffset(Offset = "0x18")]
		private readonly RatingService _ratingService;
	}
}
