using System;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Rating;
using ServicesNamespace;
using Utils;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005DD RID: 1501
	[Token(Token = "0x20005DD")]
	public class PortalsRatingController : AbstractController<PortalsRatingModel, PortalsEvents>
	{
		// Token: 0x0600243F RID: 9279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243F")]
		[Address(RVA = "0x758E", Offset = "0x758E", VA = "0x758E")]
		public PortalsRatingController(PortalsRatingModel model, PortalsEvents events)
		{
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x00006FF0 File Offset: 0x000051F0
		[Token(Token = "0x6002440")]
		[Address(RVA = "0x758F", Offset = "0x758F", VA = "0x758F")]
		public bool TryRequestAllUsersRating()
		{
			return default(bool);
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002441")]
		[Address(RVA = "0x7590", Offset = "0x7590", VA = "0x7590")]
		private void OnGetUserRating(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002442")]
		[Address(RVA = "0x7591", Offset = "0x7591", VA = "0x7591")]
		private void OnGetAllUsersRating(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x040013F3 RID: 5107
		[Token(Token = "0x40013F3")]
		[FieldOffset(Offset = "0x18")]
		private readonly RatingService _ratingService;

		// Token: 0x040013F4 RID: 5108
		[Token(Token = "0x40013F4")]
		[FieldOffset(Offset = "0x1C")]
		private ProtoGetUserPortalRatingAns _userRating;
	}
}
