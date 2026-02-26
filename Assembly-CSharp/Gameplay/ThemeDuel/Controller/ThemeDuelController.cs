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
		/* --- GHIDRA: .ctor ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelController___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  if (DAT_ram_00a585e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ThemeDuelRatingModel__RatingEvents___ctor__);
		    DAT_ram_00a585e1 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param3,param4,
		             Method_MVC_AbstractController_ThemeDuelRatingModel__RatingEvents___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/

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
