using System;
using Il2CppDummyDll;
using UI;
using UI.Elements.GenericList;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x020002FC RID: 764
	[Token(Token = "0x20002FC")]
	public class ClanSeasonRatingsOSAView : OSAGenericBase<ClanSeasonRatingsOSAView.ClansRatingsViewsHolder, ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs>
	{
		// Token: 0x060011FE RID: 4606 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011FE")]
		[Address(RVA = "0x63F9", Offset = "0x63F9", VA = "0x63F9", Slot = "119")]
		protected override ClanSeasonRatingsOSAView.ClansRatingsViewsHolder CreateViewsHolder()
		{
			return null;
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011FF")]
		[Address(RVA = "0x63FA", Offset = "0x63FA", VA = "0x63FA")]
		public ClanSeasonRatingsOSAView()
		{
		}

		// Token: 0x020002FD RID: 765
		[Token(Token = "0x20002FD")]
		public class ClansRatingsViewsHolder : ItemViewsHolder<ClanSeasonRatingsListElement>
		{
			// Token: 0x06001200 RID: 4608 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001200")]
			[Address(RVA = "0x63FB", Offset = "0x63FB", VA = "0x63FB", Slot = "13")]
			public override void SetData(GenericListElementArgs args)
			{
			}

			// Token: 0x06001201 RID: 4609 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001201")]
			[Address(RVA = "0x63FC", Offset = "0x63FC", VA = "0x63FC")]
			public ClansRatingsViewsHolder()
			{
			}
		}
	}
}
