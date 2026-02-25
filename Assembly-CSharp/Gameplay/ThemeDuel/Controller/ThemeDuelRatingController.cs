using System;
using Gameplay.Rating.Events;
using Gameplay.Rating.Model;
using Gameplay.ThemeDuel.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.ThemeDuel.Controller
{
	// Token: 0x020004EE RID: 1262
	[Token(Token = "0x20004EE")]
	public class ThemeDuelRatingController : AbstractController<ThemeDuelRatingModel, RatingEvents>
	{
		// Token: 0x06001E16 RID: 7702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E16")]
		[Address(RVA = "0x6F94", Offset = "0x6F94", VA = "0x6F94")]
		public ThemeDuelRatingController(RatingService service, ThemeDuelRatingModel model, RatingEvents events)
		{
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E17")]
		[Address(RVA = "0x6F95", Offset = "0x6F95", VA = "0x6F95")]
		public void RequestAllUsersRating(RatingRequestDto ratingRequest)
		{
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E18")]
		[Address(RVA = "0x6F96", Offset = "0x6F96", VA = "0x6F96")]
		private void OnGetUserRating(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E19")]
		[Address(RVA = "0x6F97", Offset = "0x6F97", VA = "0x6F97")]
		private void OnGetAllUsersRating(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x04001068 RID: 4200
		[Token(Token = "0x4001068")]
		[FieldOffset(Offset = "0x18")]
		private readonly RatingService _ratingService;
	}
}
