using System;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Gameplay.Billing.Events;
using Gameplay.Billing.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using OKG.Currencies;
using Protocol.Services;
using Utils;

namespace Gameplay.Billing.Controller
{
	// Token: 0x02000BF8 RID: 3064
	[Token(Token = "0x2000BF8")]
	public class HvBillingController : AbstractBillingController
	{
		// Token: 0x06004B19 RID: 19225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B19")]
		[Address(RVA = "0x9973", Offset = "0x9973", VA = "0x9973")]
		private HvBillingController(CurrencyConverter currencyConverter, AbstractBillingModel model, BillingEvents events)
		{
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1A")]
		[Address(RVA = "0x9974", Offset = "0x9974", VA = "0x9974", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1B")]
		[Address(RVA = "0x9975", Offset = "0x9975", VA = "0x9975", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1C")]
		[Address(RVA = "0x9976", Offset = "0x9976", VA = "0x9976", Slot = "12")]
		protected override void RefPayHandler(BankOptionData option, RefPayEvt msg)
		{
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1D")]
		[Address(RVA = "0x9977", Offset = "0x9977", VA = "0x9977")]
		private void OnExternalMoneyChangedEvent(double balance)
		{
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1E")]
		[Address(RVA = "0x9978", Offset = "0x9978", VA = "0x9978")]
		private void RequestBankBalance()
		{
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1F")]
		[Address(RVA = "0x9979", Offset = "0x9979", VA = "0x9979")]
		private void GetBankBalanceResponseHandler(float value)
		{
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x0000DE60 File Offset: 0x0000C060
		[Token(Token = "0x6004B20")]
		[Address(RVA = "0x997A", Offset = "0x997A", VA = "0x997A")]
		private bool ValidatePurchasesAvail()
		{
			return default(bool);
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B21")]
		[Address(RVA = "0x997B", Offset = "0x997B", VA = "0x997B")]
		private void BuyOptionInternal(BankOptionData bankOptionData)
		{
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B22")]
		[Address(RVA = "0x997C", Offset = "0x997C", VA = "0x997C")]
		private void HandleGetPaymentDataService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B23")]
		[Address(RVA = "0x997D", Offset = "0x997D", VA = "0x997D", Slot = "13")]
		public override void BuyOption(BankOptionData bankOptionData)
		{
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B24")]
		[Address(RVA = "0x997E", Offset = "0x997E", VA = "0x997E", Slot = "14")]
		public override void ConsumeIfExist()
		{
		}

		// Token: 0x02000BF9 RID: 3065
		[Token(Token = "0x2000BF9")]
		public static class HvBank
		{
			// Token: 0x02000BFA RID: 3066
			[Token(Token = "0x2000BFA")]
			public sealed class Factory : IControllerFactory
			{
				// Token: 0x06004B26 RID: 19238 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x6004B26")]
				[Address(RVA = "0x9980", Offset = "0x9980", VA = "0x9980", Slot = "4")]
				public AbstractBillingController Create(IAuthTokenSource authTokenSource, IGame game, BillingEvents events, CurrencyConverter currencyConverter)
				{
					return null;
				}

				// Token: 0x06004B27 RID: 19239 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004B27")]
				[Address(RVA = "0x9981", Offset = "0x9981", VA = "0x9981")]
				public Factory()
				{
				}
			}
		}

		// Token: 0x02000BFB RID: 3067
		[Token(Token = "0x2000BFB")]
		public static class WebGL
		{
			// Token: 0x02000BFC RID: 3068
			[Token(Token = "0x2000BFC")]
			public sealed class Factory : IControllerFactory
			{
				// Token: 0x06004B28 RID: 19240 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x6004B28")]
				[Address(RVA = "0x9982", Offset = "0x9982", VA = "0x9982", Slot = "4")]
				public AbstractBillingController Create(IAuthTokenSource authTokenSource, IGame game, BillingEvents events, CurrencyConverter currencyConverter)
				{
					return null;
				}

				// Token: 0x06004B29 RID: 19241 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004B29")]
				[Address(RVA = "0x9983", Offset = "0x9983", VA = "0x9983")]
				public Factory()
				{
				}
			}
		}
	}
}
