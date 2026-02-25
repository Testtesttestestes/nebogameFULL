using System;
using System.Collections.Generic;
using Gameplay.EndlessPaymentOptionsList.Model;
using Gameplay.SpecialOffers.Events;
using Gameplay.SpecialOffers.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using ServicesNamespace;
using Utils;
using Utils.Accumulators;
using Utils.Timers;

namespace Gameplay.SpecialOffers.Controller
{
	// Token: 0x0200050E RID: 1294
	[Token(Token = "0x200050E")]
	public class SpecialOffersController : OptionsOfferControllerBase<SpecialOffersModel, SpecialOffersEvents>
	{
		// Token: 0x06001ECE RID: 7886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECE")]
		[Address(RVA = "0x7035", Offset = "0x7035", VA = "0x7035")]
		public SpecialOffersController(SpecialOffersModel model, SpecialOffersEvents events)
		{
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECF")]
		[Address(RVA = "0x7036", Offset = "0x7036", VA = "0x7036")]
		public void GetSpecialOffer()
		{
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED0")]
		[Address(RVA = "0x7037", Offset = "0x7037", VA = "0x7037")]
		private void GetSpecialOfferResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED1")]
		[Address(RVA = "0x7038", Offset = "0x7038", VA = "0x7038")]
		private void ScheduleExpiration()
		{
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED2")]
		[Address(RVA = "0x7039", Offset = "0x7039", VA = "0x7039")]
		private void HandleExpiration()
		{
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED3")]
		[Address(RVA = "0x703A", Offset = "0x703A", VA = "0x703A")]
		private void ScheduleNextRequest(ulong ms)
		{
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED4")]
		[Address(RVA = "0x703B", Offset = "0x703B", VA = "0x703B")]
		public void CancelSpecialOffer(uint optionId, bool purchased)
		{
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED5")]
		[Address(RVA = "0x703C", Offset = "0x703C", VA = "0x703C")]
		private void CancelSpecialOfferResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED6")]
		[Address(RVA = "0x703D", Offset = "0x703D", VA = "0x703D")]
		public void SetViewed(bool viewed)
		{
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED7")]
		[Address(RVA = "0x703E", Offset = "0x703E", VA = "0x703E", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED8")]
		[Address(RVA = "0x703F", Offset = "0x703F", VA = "0x703F", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED9")]
		[Address(RVA = "0x7040", Offset = "0x7040", VA = "0x7040")]
		private void UserOnOnTriggerChangedEventHandler(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
		{
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EDA")]
		[Address(RVA = "0x7041", Offset = "0x7041", VA = "0x7041")]
		private void HandleEndlessOptionsListChangedEvent()
		{
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EDB")]
		[Address(RVA = "0x7042", Offset = "0x7042", VA = "0x7042")]
		private void HandleEndlessOptionsListTimeOutEvent()
		{
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EDC")]
		[Address(RVA = "0x7043", Offset = "0x7043", VA = "0x7043")]
		private void HandleEndlessOptionsListBuySuccessEvent(CardData a, CardData b)
		{
		}

		// Token: 0x040010B7 RID: 4279
		[Token(Token = "0x40010B7")]
		[FieldOffset(Offset = "0x18")]
		private ServicesService _service;

		// Token: 0x040010B8 RID: 4280
		[Token(Token = "0x40010B8")]
		[FieldOffset(Offset = "0x1C")]
		private DelayedCall _delayedRequest;

		// Token: 0x040010B9 RID: 4281
		[Token(Token = "0x40010B9")]
		[FieldOffset(Offset = "0x20")]
		private DelayedCall _delayedExpiration;
	}
}
