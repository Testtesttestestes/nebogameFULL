using System;
using Gameplay.Bank.Model;
using Gameplay.SpecialOffers.Events;
using Gameplay.SpecialOffers.Model;
using Gameplay.SpecialOffers.View;
using Il2CppDummyDll;

namespace Gameplay.SpecialOffers.Controller
{
	// Token: 0x02000512 RID: 1298
	[Token(Token = "0x2000512")]
	public class SpecialOffersViewMediator : OptionsOfferViewMediatorBase<SpecialOffersModel, SpecialOffersEvents, SpecialOffersController, SpecialOffersWindow>
	{
		// Token: 0x06001EEF RID: 7919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EEF")]
		[Address(RVA = "0x7056", Offset = "0x7056", VA = "0x7056")]
		public SpecialOffersViewMediator(SpecialOffersModel model, SpecialOffersEvents events, SpecialOffersController controller)
		{
		}

		// Token: 0x1700059F RID: 1439
		// (set) Token: 0x06001EF0 RID: 7920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059F")]
		public override SpecialOffersEvents Events
		{
			[Token(Token = "0x6001EF0")]
			[Address(RVA = "0x7057", Offset = "0x7057", VA = "0x7057", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF1")]
		[Address(RVA = "0x7058", Offset = "0x7058", VA = "0x7058")]
		private void SpecialOfferRequestedEventHandler()
		{
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF2")]
		[Address(RVA = "0x7059", Offset = "0x7059", VA = "0x7059")]
		private void UserTriggersChangedEventHandler()
		{
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF3")]
		[Address(RVA = "0x705A", Offset = "0x705A", VA = "0x705A", Slot = "22")]
		protected override void BuyOptionSuccessHandler(BankOptionData data)
		{
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF4")]
		[Address(RVA = "0x705B", Offset = "0x705B", VA = "0x705B", Slot = "23")]
		protected override void BuyOptionErrorHandler(BankOptionData data)
		{
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF5")]
		[Address(RVA = "0x705C", Offset = "0x705C", VA = "0x705C", Slot = "21")]
		protected override void UpdateView()
		{
		}
	}
}
