using System;
using System.Collections.Generic;
using Core.Events;
using Core.Events.Scopes;
using Gameplay.Bank.Model;
using Gameplay.Billing.Model;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C4 RID: 4804
	[Token(Token = "0x20012C4")]
	public class BillingAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x0600721A RID: 29210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001728")]
		protected override string Theme
		{
			[Token(Token = "0x600721A")]
			[Address(RVA = "0xBC23", Offset = "0xBC23", VA = "0xBC23", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600721B RID: 29211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600721B")]
		[Address(RVA = "0xBC24", Offset = "0xBC24", VA = "0xBC24", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x0600721C RID: 29212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600721C")]
		[Address(RVA = "0xBC25", Offset = "0xBC25", VA = "0xBC25", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x0600721D RID: 29213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600721D")]
		[Address(RVA = "0xBC26", Offset = "0xBC26", VA = "0xBC26")]
		private void RefPayEvent(BillingScope.RefPayInfoEventArgs e)
		{
		}

		// Token: 0x0600721E RID: 29214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600721E")]
		[Address(RVA = "0xBC27", Offset = "0xBC27", VA = "0xBC27")]
		private void ProviderSelectedEvent(BillingScope.BuyOptionEventArgs e)
		{
		}

		// Token: 0x0600721F RID: 29215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600721F")]
		[Address(RVA = "0xBC28", Offset = "0xBC28", VA = "0xBC28")]
		private void ShowSelectBillingDialogEvent(BillingScope.BuyOptionEventArgs e)
		{
		}

		// Token: 0x06007220 RID: 29216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007220")]
		[Address(RVA = "0xBC29", Offset = "0xBC29", VA = "0xBC29")]
		private void PurchaseRequirementsErrorEvent(BillingScope.BuyOptionErrorEventArgs e)
		{
		}

		// Token: 0x06007221 RID: 29217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007221")]
		[Address(RVA = "0xBC2A", Offset = "0xBC2A", VA = "0xBC2A")]
		private void RequestProductsErrorEvent(BillingScope.RequestProductsInfoArgs e)
		{
		}

		// Token: 0x06007222 RID: 29218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007222")]
		[Address(RVA = "0xBC2B", Offset = "0xBC2B", VA = "0xBC2B")]
		private void InvalidProductsInfoEvent(BillingScope.RequestProductsInfoArgs e)
		{
		}

		// Token: 0x06007223 RID: 29219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007223")]
		[Address(RVA = "0xBC2C", Offset = "0xBC2C", VA = "0xBC2C")]
		private void BuyOptionRequestMarketEvent(BillingScope.BuyOptionEventArgs e)
		{
		}

		// Token: 0x06007224 RID: 29220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007224")]
		[Address(RVA = "0xBC2D", Offset = "0xBC2D", VA = "0xBC2D")]
		private void BuyOptionRequestInfoEvent(BillingScope.BuyOptionEventArgs e)
		{
		}

		// Token: 0x06007225 RID: 29221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007225")]
		[Address(RVA = "0xBC2E", Offset = "0xBC2E", VA = "0xBC2E")]
		private void OnRestoreTransactionCompleteEvent(BaseEventBusEventArgs e)
		{
		}

		// Token: 0x06007226 RID: 29222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007226")]
		[Address(RVA = "0xBC2F", Offset = "0xBC2F", VA = "0xBC2F")]
		private void BuyOptionCancelEvent(BillingScope.BuyOptionEventArgs e)
		{
		}

		// Token: 0x06007227 RID: 29223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007227")]
		[Address(RVA = "0xBC30", Offset = "0xBC30", VA = "0xBC30")]
		private void BuyOptionPendingPurchaseEvent(BillingScope.BuyOptionEventArgs e)
		{
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007228")]
		[Address(RVA = "0xBC31", Offset = "0xBC31", VA = "0xBC31")]
		private void CurrencyConvertErrorEvent(BillingScope.CurrencyConverterErrorEventArgs e)
		{
		}

		// Token: 0x06007229 RID: 29225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007229")]
		[Address(RVA = "0xBC32", Offset = "0xBC32", VA = "0xBC32")]
		private void PurchaseInfoEvent(BillingScope.PurchaseInfoEventArgs e)
		{
		}

		// Token: 0x0600722A RID: 29226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600722A")]
		[Address(RVA = "0xBC33", Offset = "0xBC33", VA = "0xBC33")]
		private void BuyOptionErrorEvent(BillingScope.BuyOptionErrorEventArgs e)
		{
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600722B")]
		[Address(RVA = "0xBC34", Offset = "0xBC34", VA = "0xBC34")]
		private void BuyOptionSuccessEvent(BillingScope.BuyOptionEventArgs e)
		{
		}

		// Token: 0x0600722C RID: 29228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600722C")]
		[Address(RVA = "0xBC35", Offset = "0xBC35", VA = "0xBC35")]
		private void AppendBankOptionDataProperties(Dictionary<string, object> properties, BankOptionData optionData)
		{
		}

		// Token: 0x0600722D RID: 29229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600722D")]
		[Address(RVA = "0xBC36", Offset = "0xBC36", VA = "0xBC36")]
		private void AppendJsonPayload(Dictionary<string, object> properties, string jsonPayload)
		{
		}

		// Token: 0x0600722E RID: 29230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600722E")]
		[Address(RVA = "0xBC37", Offset = "0xBC37", VA = "0xBC37")]
		private void AppendPurchaseProperties(Dictionary<string, object> properties, PurchaseDto purchase)
		{
		}

		// Token: 0x0600722F RID: 29231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600722F")]
		[Address(RVA = "0xBC38", Offset = "0xBC38", VA = "0xBC38")]
		public BillingAnalyticsListener()
		{
		}

		// Token: 0x04003BCB RID: 15307
		[Token(Token = "0x4003BCB")]
		private const string REQUEST_OPTION_INFO = "request_option_info";

		// Token: 0x04003BCC RID: 15308
		[Token(Token = "0x4003BCC")]
		private const string SHOW_PURCHASE_DIALOG = "show_purchase_dialog";

		// Token: 0x04003BCD RID: 15309
		[Token(Token = "0x4003BCD")]
		private const string ON_RESTORE_TRANSACTION = "on_restore_transaction";

		// Token: 0x04003BCE RID: 15310
		[Token(Token = "0x4003BCE")]
		private const string PURCHASE_CANCELED = "purchase_canceled";

		// Token: 0x04003BCF RID: 15311
		[Token(Token = "0x4003BCF")]
		private const string PURCHASE_PENDING = "purchase_pending";

		// Token: 0x04003BD0 RID: 15312
		[Token(Token = "0x4003BD0")]
		private const string PURCHASE_SUCCESS = "purchase_success";

		// Token: 0x04003BD1 RID: 15313
		[Token(Token = "0x4003BD1")]
		private const string PURCHASE_ERROR = "purchase_error";

		// Token: 0x04003BD2 RID: 15314
		[Token(Token = "0x4003BD2")]
		private const string CURRENCY_CONVERTER_ERROR = "currency_converter_error";

		// Token: 0x04003BD3 RID: 15315
		[Token(Token = "0x4003BD3")]
		private const string INVALID_PRODUCTS = "invalid_products";

		// Token: 0x04003BD4 RID: 15316
		[Token(Token = "0x4003BD4")]
		private const string REQUEST_PRODUCTS_ERROR = "request_products_error";

		// Token: 0x04003BD5 RID: 15317
		[Token(Token = "0x4003BD5")]
		private const string PURCHASE_INTENT_FAILED = "purchase_intent_failed";

		// Token: 0x04003BD6 RID: 15318
		[Token(Token = "0x4003BD6")]
		private const string SHOW_SELECT_BILLING_DIALOG = "show_select_billing_dialog";

		// Token: 0x04003BD7 RID: 15319
		[Token(Token = "0x4003BD7")]
		private const string PROVIDER_SELECTED = "provider_selected";

		// Token: 0x04003BD8 RID: 15320
		[Token(Token = "0x4003BD8")]
		private const string REF_PAY = "ref_pay";
	}
}
