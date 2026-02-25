using System;
using Gameplay.VortexRating.Events;
using Gameplay.VortexRating.Model;
using Gameplay.VortexRating.View.VoteRewardsTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.VortexRating.Controller
{
	// Token: 0x020003A2 RID: 930
	[Token(Token = "0x20003A2")]
	public class VoteRewardsViewMediator : AbstractViewMediator<VortexRatingModel, VortexRatingEvents, VortexRatingController, VoteRewardsView>, IHideableMediator
	{
		// Token: 0x060015AF RID: 5551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015AF")]
		[Address(RVA = "0x6771", Offset = "0x6771", VA = "0x6771")]
		public VoteRewardsViewMediator(VortexRatingModel model, VortexRatingEvents events, VortexRatingController controller)
		{
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060015B1 RID: 5553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000393")]
		public GiftListElement[] ListElements
		{
			[Token(Token = "0x60015B0")]
			[Address(RVA = "0x6772", Offset = "0x6772", VA = "0x6772")]
			get
			{
				return null;
			}
			[Token(Token = "0x60015B1")]
			[Address(RVA = "0x6773", Offset = "0x6773", VA = "0x6773")]
			set
			{
			}
		}

		// Token: 0x17000394 RID: 916
		// (set) Token: 0x060015B2 RID: 5554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000394")]
		public override VoteRewardsView View
		{
			[Token(Token = "0x60015B2")]
			[Address(RVA = "0x6774", Offset = "0x6774", VA = "0x6774", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000395 RID: 917
		// (set) Token: 0x060015B3 RID: 5555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000395")]
		public override VortexRatingEvents Events
		{
			[Token(Token = "0x60015B3")]
			[Address(RVA = "0x6775", Offset = "0x6775", VA = "0x6775", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B4")]
		[Address(RVA = "0x6776", Offset = "0x6776", VA = "0x6776")]
		private void GreatTopRequestedEventHandler()
		{
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B5")]
		[Address(RVA = "0x6777", Offset = "0x6777", VA = "0x6777")]
		private void Init()
		{
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B6")]
		[Address(RVA = "0x6778", Offset = "0x6778", VA = "0x6778")]
		private void GiftListElementClickedEventHandler(GiftListElement element)
		{
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B7")]
		[Address(RVA = "0x6779", Offset = "0x6779", VA = "0x6779")]
		private void SelectElement(GiftListElement element)
		{
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B8")]
		[Address(RVA = "0x677A", Offset = "0x677A", VA = "0x677A")]
		private void SetGiftButtonClickedEventHandler()
		{
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B9")]
		[Address(RVA = "0x677B", Offset = "0x677B", VA = "0x677B")]
		private void GreatSetAssignedEventHandler(uint greatSetId)
		{
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015BA")]
		[Address(RVA = "0x677C", Offset = "0x677C", VA = "0x677C")]
		private void AssignGreatSet(uint greatSetId)
		{
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015BB")]
		[Address(RVA = "0x677D", Offset = "0x677D", VA = "0x677D", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x04000B7A RID: 2938
		[Token(Token = "0x4000B7A")]
		[FieldOffset(Offset = "0x18")]
		private GiftListElement[] _listElements;

		// Token: 0x04000B7B RID: 2939
		[Token(Token = "0x4000B7B")]
		[FieldOffset(Offset = "0x1C")]
		private GiftListElement _selectedGift;
	}
}
