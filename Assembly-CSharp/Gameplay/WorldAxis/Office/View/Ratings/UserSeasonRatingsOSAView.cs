using System;
using Il2CppDummyDll;
using UI;
using UI.Elements.GenericList;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x02000307 RID: 775
	[Token(Token = "0x2000307")]
	public class UserSeasonRatingsOSAView : OSAGenericBase<UserSeasonRatingsOSAView.UsersRatingsViewsHolder, UserSeasonRatingsListElement.UserSeasonRatingsListElementArgs>
	{
		// Token: 0x0600121E RID: 4638 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600121E")]
		[Address(RVA = "0x6419", Offset = "0x6419", VA = "0x6419", Slot = "119")]
		protected override UserSeasonRatingsOSAView.UsersRatingsViewsHolder CreateViewsHolder()
		{
			return null;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600121F")]
		[Address(RVA = "0x641A", Offset = "0x641A", VA = "0x641A")]
		public UserSeasonRatingsOSAView()
		{
		}

		// Token: 0x02000308 RID: 776
		[Token(Token = "0x2000308")]
		public class UsersRatingsViewsHolder : ItemViewsHolder<UserSeasonRatingsListElement>
		{
			// Token: 0x06001220 RID: 4640 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001220")]
			[Address(RVA = "0x641B", Offset = "0x641B", VA = "0x641B", Slot = "13")]
			public override void SetData(GenericListElementArgs args)
			{
			}

			// Token: 0x06001221 RID: 4641 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001221")]
			[Address(RVA = "0x641C", Offset = "0x641C", VA = "0x641C")]
			public UsersRatingsViewsHolder()
			{
			}
		}
	}
}
