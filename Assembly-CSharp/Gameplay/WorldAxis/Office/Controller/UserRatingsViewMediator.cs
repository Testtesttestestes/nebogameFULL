using System;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View.Ratings;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002E3 RID: 739
	[Token(Token = "0x20002E3")]
	public class UserRatingsViewMediator : AbstractViewMediator<RatingsModel, RatingsEvents, RatingsController, UserRatingsView>, IHideableMediator
	{
		// Token: 0x0600117C RID: 4476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600117C")]
		[Address(RVA = "0x6379", Offset = "0x6379", VA = "0x6379")]
		public UserRatingsViewMediator(RatingsModel model, RatingsEvents events, RatingsController controller)
		{
		}

		// Token: 0x17000294 RID: 660
		// (set) Token: 0x0600117D RID: 4477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000294")]
		public override UserRatingsView View
		{
			[Token(Token = "0x600117D")]
			[Address(RVA = "0x637A", Offset = "0x637A", VA = "0x637A", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600117E")]
		[Address(RVA = "0x637B", Offset = "0x637B", VA = "0x637B")]
		private void ResetView()
		{
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600117F")]
		[Address(RVA = "0x637C", Offset = "0x637C", VA = "0x637C")]
		private void SetupView()
		{
		}

		// Token: 0x17000295 RID: 661
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000295")]
		public override RatingsEvents Events
		{
			[Token(Token = "0x6001180")]
			[Address(RVA = "0x637D", Offset = "0x637D", VA = "0x637D", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001181")]
		[Address(RVA = "0x637E", Offset = "0x637E", VA = "0x637E")]
		private void InitEventHandler()
		{
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001182")]
		[Address(RVA = "0x637F", Offset = "0x637F", VA = "0x637F")]
		private void InjectCategoriesCallback()
		{
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001183")]
		[Address(RVA = "0x6380", Offset = "0x6380", VA = "0x6380")]
		private void SortCategoryClickedEventHandler(SortCategoryListElement element)
		{
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001184")]
		[Address(RVA = "0x6381", Offset = "0x6381", VA = "0x6381")]
		private void UserRatingsRequestedEventHandler()
		{
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001185")]
		[Address(RVA = "0x6382", Offset = "0x6382", VA = "0x6382")]
		private void UpdateList()
		{
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001186")]
		[Address(RVA = "0x6383", Offset = "0x6383", VA = "0x6383", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x04000900 RID: 2304
		[Token(Token = "0x4000900")]
		[FieldOffset(Offset = "0x18")]
		private SortCategoryListElement _currentSortCategory;
	}
}
