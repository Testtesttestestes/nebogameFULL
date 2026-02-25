using System;
using System.Collections.Generic;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.Billing.Events;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Services;
using ServicesNamespace;
using Utils;
using Utils.Accumulators;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C61 RID: 3169
	[Token(Token = "0x2000C61")]
	public class BankController : AbstractController<BankModel, BankEvents>
	{
		// Token: 0x06004D5A RID: 19802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5A")]
		[Address(RVA = "0x9B93", Offset = "0x9B93", VA = "0x9B93", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5B")]
		[Address(RVA = "0x9B94", Offset = "0x9B94", VA = "0x9B94")]
		public BankController(BankModel model, BankEvents events, BillingEvents billingEvents)
		{
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5C")]
		[Address(RVA = "0x9B95", Offset = "0x9B95", VA = "0x9B95", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5D")]
		[Address(RVA = "0x9B96", Offset = "0x9B96", VA = "0x9B96", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06004D5E RID: 19806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5E")]
		[Address(RVA = "0x9B97", Offset = "0x9B97", VA = "0x9B97")]
		private void ResetEvents()
		{
		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5F")]
		[Address(RVA = "0x9B98", Offset = "0x9B98", VA = "0x9B98")]
		private void SetupEvents()
		{
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D60")]
		[Address(RVA = "0x9B99", Offset = "0x9B99", VA = "0x9B99")]
		private void HandleInit()
		{
		}

		// Token: 0x06004D61 RID: 19809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D61")]
		[Address(RVA = "0x9B9A", Offset = "0x9B9A", VA = "0x9B9A")]
		private void HandleDictChangedEvent()
		{
		}

		// Token: 0x06004D62 RID: 19810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D62")]
		[Address(RVA = "0x9B9B", Offset = "0x9B9B", VA = "0x9B9B")]
		private void UserOnOnTriggerChangedEvent(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
		{
		}

		// Token: 0x06004D63 RID: 19811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D63")]
		[Address(RVA = "0x9B9C", Offset = "0x9B9C", VA = "0x9B9C")]
		private void HandlePaymentRewardsChangedEvent(ProtoPaymentRewardsChangedEvt msg)
		{
		}

		// Token: 0x06004D64 RID: 19812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D64")]
		[Address(RVA = "0x9B9D", Offset = "0x9B9D", VA = "0x9B9D")]
		private void BuyOptionPendingEvent(BankOptionData bankOptionData)
		{
		}

		// Token: 0x06004D65 RID: 19813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D65")]
		[Address(RVA = "0x9B9E", Offset = "0x9B9E", VA = "0x9B9E")]
		private void BuyOptionCancelEvent(BankOptionData bankOptionData)
		{
		}

		// Token: 0x06004D66 RID: 19814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D66")]
		[Address(RVA = "0x9B9F", Offset = "0x9B9F", VA = "0x9B9F")]
		private void BuyOptionErrorEvent(BankOptionData bankOptionData)
		{
		}

		// Token: 0x06004D67 RID: 19815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D67")]
		[Address(RVA = "0x9BA0", Offset = "0x9BA0", VA = "0x9BA0")]
		private void BuyOptionSuccessEvent(BankOptionData bankOptionData)
		{
		}

		// Token: 0x06004D68 RID: 19816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D68")]
		[Address(RVA = "0x9BA1", Offset = "0x9BA1", VA = "0x9BA1")]
		private void HandleServiceEvaluatePaymentRewards(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004D69 RID: 19817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D69")]
		[Address(RVA = "0x9BA2", Offset = "0x9BA2", VA = "0x9BA2")]
		private void HandleServiceGetActivePromotions(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004D6A RID: 19818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D6A")]
		[Address(RVA = "0x9BA3", Offset = "0x9BA3", VA = "0x9BA3")]
		private void HandleServiceGetOptionArtikuls(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004D6B RID: 19819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D6B")]
		[Address(RVA = "0x9BA4", Offset = "0x9BA4", VA = "0x9BA4")]
		private void HandleDoExchangeService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004D6C RID: 19820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D6C")]
		[Address(RVA = "0x9BA5", Offset = "0x9BA5", VA = "0x9BA5")]
		private void SetOptionsRewards(IList<OptionRewards> rewards)
		{
		}

		// Token: 0x06004D6D RID: 19821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D6D")]
		[Address(RVA = "0x1F10", Offset = "0x1F10", VA = "0x1F10")]
		public void RequestAvailableOptions()
		{
		}

		// Token: 0x06004D6E RID: 19822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D6E")]
		[Address(RVA = "0x9BA6", Offset = "0x9BA6", VA = "0x9BA6")]
		public void RequestActivePromotions()
		{
		}

		// Token: 0x06004D6F RID: 19823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D6F")]
		[Address(RVA = "0x9BA7", Offset = "0x9BA7", VA = "0x9BA7")]
		public void BuyOption(BankOptionData bankOptionData)
		{
		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D70")]
		[Address(RVA = "0x9BA8", Offset = "0x9BA8", VA = "0x9BA8")]
		public void GetOptionArtikuls(BankOptionData bankOptionData)
		{
		}

		// Token: 0x06004D71 RID: 19825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D71")]
		[Address(RVA = "0x9BA9", Offset = "0x9BA9", VA = "0x9BA9")]
		public void SetEpNotifications(int value)
		{
		}

		// Token: 0x04002A3A RID: 10810
		[Token(Token = "0x4002A3A")]
		[FieldOffset(Offset = "0x18")]
		private BillingEvents _billingEvents;

		// Token: 0x04002A3B RID: 10811
		[Token(Token = "0x4002A3B")]
		[FieldOffset(Offset = "0x1C")]
		private ServicesService _servicesService;

		// Token: 0x04002A3C RID: 10812
		[Token(Token = "0x4002A3C")]
		[FieldOffset(Offset = "0x20")]
		private bool _optionsRequestingNow;
	}
}
