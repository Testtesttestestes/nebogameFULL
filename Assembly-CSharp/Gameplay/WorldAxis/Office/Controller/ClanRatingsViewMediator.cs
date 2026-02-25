using System;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View.Ratings;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002DC RID: 732
	[Token(Token = "0x20002DC")]
	public class ClanRatingsViewMediator : AbstractViewMediator<RatingsModel, RatingsEvents, RatingsController, ClanRatingsView>, IHideableMediator
	{
		// Token: 0x06001135 RID: 4405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001135")]
		[Address(RVA = "0x6332", Offset = "0x6332", VA = "0x6332")]
		public ClanRatingsViewMediator(RatingsModel model, RatingsEvents events, RatingsController controller)
		{
		}

		// Token: 0x1700028C RID: 652
		// (set) Token: 0x06001136 RID: 4406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028C")]
		public override ClanRatingsView View
		{
			[Token(Token = "0x6001136")]
			[Address(RVA = "0x6333", Offset = "0x6333", VA = "0x6333", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001137")]
		[Address(RVA = "0x6334", Offset = "0x6334", VA = "0x6334")]
		private void ResetView()
		{
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001138")]
		[Address(RVA = "0x6335", Offset = "0x6335", VA = "0x6335")]
		private void SetupView()
		{
		}

		// Token: 0x1700028D RID: 653
		// (set) Token: 0x06001139 RID: 4409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028D")]
		public override RatingsEvents Events
		{
			[Token(Token = "0x6001139")]
			[Address(RVA = "0x6336", Offset = "0x6336", VA = "0x6336", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113A")]
		[Address(RVA = "0x6337", Offset = "0x6337", VA = "0x6337")]
		private void InjectCategoriesCallback()
		{
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113B")]
		[Address(RVA = "0x6338", Offset = "0x6338", VA = "0x6338")]
		private void InjectCallback()
		{
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113C")]
		[Address(RVA = "0x6339", Offset = "0x6339", VA = "0x6339")]
		private void ClanListElementClickedEventHandler(ClanSeasonRatingsListElement element)
		{
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113D")]
		[Address(RVA = "0x633A", Offset = "0x633A", VA = "0x633A")]
		private void SortCategoryClickedEventHandler(SortCategoryListElement element)
		{
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113E")]
		[Address(RVA = "0x633B", Offset = "0x633B", VA = "0x633B")]
		private void ClanRatingsRequestedEventHandler()
		{
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113F")]
		[Address(RVA = "0x633C", Offset = "0x633C", VA = "0x633C")]
		private void UpdateList()
		{
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001140")]
		[Address(RVA = "0x633D", Offset = "0x633D", VA = "0x633D", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x040008F8 RID: 2296
		[Token(Token = "0x40008F8")]
		[FieldOffset(Offset = "0x18")]
		private SortCategoryListElement _currentSortCategory;
	}
}
