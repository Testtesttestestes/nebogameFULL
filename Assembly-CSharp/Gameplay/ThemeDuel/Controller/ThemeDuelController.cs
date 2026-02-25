using System;
using Gameplay.ThemeDuel.Events;
using Gameplay.ThemeDuel.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.ThemeDuel.Controller
{
	// Token: 0x020004ED RID: 1261
	[Token(Token = "0x20004ED")]
	public class ThemeDuelController : AbstractController<ThemeDuelModel, ThemeDuelEvents>
	{
		// Token: 0x06001E15 RID: 7701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E15")]
		[Address(RVA = "0x6F93", Offset = "0x6F93", VA = "0x6F93")]
		public ThemeDuelController(ThemeDuelRatingController ratingController, ThemeDuelShopController shopController, ThemeDuelModel model, ThemeDuelEvents events)
		{
		}

		// Token: 0x04001066 RID: 4198
		[Token(Token = "0x4001066")]
		[FieldOffset(Offset = "0x18")]
		public readonly ThemeDuelRatingController RatingController;

		// Token: 0x04001067 RID: 4199
		[Token(Token = "0x4001067")]
		[FieldOffset(Offset = "0x1C")]
		public readonly ThemeDuelShopController ShopController;
	}
}
