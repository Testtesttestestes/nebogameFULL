using System;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Gameplay.Bank.View;
using Gameplay.SpecialOffers.Events;
using Gameplay.SpecialOffers.Model;
using Gameplay.SpecialOffers.View;
using Il2CppDummyDll;
using MVC;
using UI;
using UnityEngine;

namespace Gameplay.SpecialOffers.Controller
{
	// Token: 0x0200050D RID: 1293
	[Token(Token = "0x200050D")]
	public abstract class OptionsOfferViewMediatorBase<M, E, C, V> : AbstractViewMediator<M, E, C, V> where M : OptionsOfferModel where E : OptionsOfferEvents where C : OptionsOfferControllerBase<M, E> where V : Component, IOptionsOfferWindow
	{
		// Token: 0x06001EC3 RID: 7875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC3")]
		protected OptionsOfferViewMediatorBase(M model, E events, C controller)
		{
		}

		// Token: 0x1700059C RID: 1436
		// (set) Token: 0x06001EC4 RID: 7876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059C")]
		public override V View
		{
			[Token(Token = "0x6001EC4")]
			set
			{
			}
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC5")]
		private void PickerOnSelectionChangedEvent(BankOptionListElement.BankOptionListElementArgs obj)
		{
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC6")]
		protected virtual void UpdateView()
		{
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC7")]
		private void ToMailButtonClickedEventHandler()
		{
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC8")]
		private void BuyButtonClickedEventHandler(BankOptionData data)
		{
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC9")]
		private void ForceViewSelectedEventHandler(BankOptionListElement.BankOptionListElementArgs args)
		{
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECA")]
		protected virtual void BuyOptionSuccessHandler(BankOptionData data)
		{
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECB")]
		protected virtual void BuyOptionErrorHandler(BankOptionData data)
		{
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECC")]
		private void InBankButtonClickedEventHandler(IndexButtonBasic _)
		{
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001ECD")]
		private BankOptionListElement.BankOptionListElementArgs ConstructArgs(BankOptionData data)
		{
			return null;
		}

		// Token: 0x040010B6 RID: 4278
		[Token(Token = "0x40010B6")]
		[FieldOffset(Offset = "0x0")]
		private IGame _game;
	}
}
