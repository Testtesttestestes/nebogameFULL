using System;
using System.Runtime.CompilerServices;
using Gameplay.Bank.Model;
using Gameplay.Billing.Events;
using Gameplay.Billing.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using OKG.Currencies;
using Protocol.Services;

namespace Gameplay.Billing.Controller
{
	// Token: 0x02000BF7 RID: 3063
	[Token(Token = "0x2000BF7")]
	public abstract class AbstractBillingController : AbstractController<AbstractBillingModel, BillingEvents>
	{
		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06004B0F RID: 19215 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004B10 RID: 19216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F28")]
		private protected CurrencyConverter CurrencyConverter
		{
			[Token(Token = "0x6004B0F")]
			[Address(RVA = "0x996C", Offset = "0x996C", VA = "0x996C")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6004B10")]
			[Address(RVA = "0x996D", Offset = "0x996D", VA = "0x996D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B11")]
		[Address(RVA = "0x996E", Offset = "0x996E", VA = "0x996E", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06004B12 RID: 19218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B12")]
		[Address(RVA = "0x996F", Offset = "0x996F", VA = "0x996F")]
		protected AbstractBillingController([NotNull] CurrencyConverter currencyConverter, [NotNull] AbstractBillingModel model, [NotNull] BillingEvents events)
		{
		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B13")]
		[Address(RVA = "0x9970", Offset = "0x9970", VA = "0x9970", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B14")]
		[Address(RVA = "0x9971", Offset = "0x9971", VA = "0x9971", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06004B15 RID: 19221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B15")]
		[Address(RVA = "0x9972", Offset = "0x9972", VA = "0x9972")]
		private void HandleRefPayEvent(RefPayEvt msg)
		{
		}

		// Token: 0x06004B16 RID: 19222
		[Token(Token = "0x6004B16")]
		protected abstract void RefPayHandler(BankOptionData option, RefPayEvt msg);

		// Token: 0x06004B17 RID: 19223
		[Token(Token = "0x6004B17")]
		public abstract void BuyOption(BankOptionData bankOptionData);

		// Token: 0x06004B18 RID: 19224
		[Token(Token = "0x6004B18")]
		public abstract void ConsumeIfExist();
	}
}
