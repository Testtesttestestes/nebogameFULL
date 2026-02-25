using System;
using System.Collections.Generic;
using Gameplay.Bank.Model;
using Gameplay.EndlessPaymentOptionsList.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Services;
using Utils;
using Utils.Accumulators;
using Utils.Timers;

namespace Gameplay.EndlessPaymentOptionsList.Control
{
	// Token: 0x02000850 RID: 2128
	[Token(Token = "0x2000850")]
	public class EndlessPaymentOptionsListController : AbstractController<EndlessPaymentOptionsListModel, EndlessPaymentOptionsListEvents>
	{
		// Token: 0x060031FC RID: 12796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FC")]
		[Address(RVA = "0x8252", Offset = "0x8252", VA = "0x8252", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FD")]
		[Address(RVA = "0x8253", Offset = "0x8253", VA = "0x8253")]
		public EndlessPaymentOptionsListController(EndlessPaymentOptionsListModel model, EndlessPaymentOptionsListEvents events)
		{
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FE")]
		[Address(RVA = "0x8254", Offset = "0x8254", VA = "0x8254", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FF")]
		[Address(RVA = "0x8255", Offset = "0x8255", VA = "0x8255", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003200")]
		[Address(RVA = "0x8256", Offset = "0x8256", VA = "0x8256")]
		private void HandleTriggersOnUpdateEvent(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
		{
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003201")]
		[Address(RVA = "0x8257", Offset = "0x8257", VA = "0x8257")]
		private void HandleBillingBuyOptionSuccessEvent(BankOptionData data)
		{
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003202")]
		[Address(RVA = "0x8258", Offset = "0x8258", VA = "0x8258")]
		private void HandleBankDoExchangeSuccessEvent(BankOptionData data)
		{
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003203")]
		[Address(RVA = "0x8259", Offset = "0x8259", VA = "0x8259")]
		private void HandleDictChangeEvent()
		{
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003204")]
		[Address(RVA = "0x825A", Offset = "0x825A", VA = "0x825A")]
		private void HandleDiscountOffer()
		{
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003205")]
		[Address(RVA = "0x825B", Offset = "0x825B", VA = "0x825B")]
		private void ShowDiscountOffer()
		{
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003206")]
		[Address(RVA = "0x825C", Offset = "0x825C", VA = "0x825C")]
		private void ValidateInit()
		{
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003207")]
		[Address(RVA = "0x825D", Offset = "0x825D", VA = "0x825D")]
		private void RequestOption()
		{
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003208")]
		[Address(RVA = "0x825E", Offset = "0x825E", VA = "0x825E")]
		private void HandleGetEndlessPaymentOptionsService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003209")]
		[Address(RVA = "0x825F", Offset = "0x825F", VA = "0x825F")]
		private void SetInfo(ProtoGetEndlessPaymentOptionsAns info)
		{
		}

		// Token: 0x0600320A RID: 12810 RVA: 0x0000A398 File Offset: 0x00008598
		[Token(Token = "0x600320A")]
		[Address(RVA = "0x8260", Offset = "0x8260", VA = "0x8260")]
		private bool TryToPlanDiscountOffer()
		{
			return default(bool);
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600320B")]
		[Address(RVA = "0x8261", Offset = "0x8261", VA = "0x8261")]
		private void HandlePurchaseSuccess(CardData cardData)
		{
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600320C")]
		[Address(RVA = "0x8262", Offset = "0x8262", VA = "0x8262")]
		public void UpdateOptions()
		{
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600320D")]
		[Address(RVA = "0x8263", Offset = "0x8263", VA = "0x8263")]
		public void RequestForShow()
		{
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x0000A3B0 File Offset: 0x000085B0
		[Token(Token = "0x600320E")]
		[Address(RVA = "0x8264", Offset = "0x8264", VA = "0x8264")]
		public bool TryBuy(CardData data)
		{
			return default(bool);
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600320F")]
		[Address(RVA = "0x8265", Offset = "0x8265", VA = "0x8265")]
		public void ApplyDiscount(EndlessPaymentOptionListData listData)
		{
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003210")]
		[Address(RVA = "0x8266", Offset = "0x8266", VA = "0x8266")]
		public void Reset()
		{
		}

		// Token: 0x04001B67 RID: 7015
		[Token(Token = "0x4001B67")]
		[FieldOffset(Offset = "0x18")]
		private DelayedCall _discountOfferInvoker;
	}
}
