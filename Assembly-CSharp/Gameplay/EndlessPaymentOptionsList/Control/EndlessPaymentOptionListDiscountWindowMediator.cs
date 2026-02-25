using System;
using Gameplay.EndlessPaymentOptionsList.Model;
using Gameplay.EndlessPaymentOptionsList.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.EndlessPaymentOptionsList.Control
{
	// Token: 0x0200084F RID: 2127
	[Token(Token = "0x200084F")]
	public class EndlessPaymentOptionListDiscountWindowMediator : AbstractViewMediator<EndlessPaymentOptionsListModel, EndlessPaymentOptionsListEvents, EndlessPaymentOptionsListController, EndlessPaymentOptionsListDiscountWindow>
	{
		// Token: 0x060031F6 RID: 12790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F6")]
		[Address(RVA = "0x824C", Offset = "0x824C", VA = "0x824C")]
		public EndlessPaymentOptionListDiscountWindowMediator(EndlessPaymentOptionsListModel model, EndlessPaymentOptionsListEvents events, EndlessPaymentOptionsListController controller)
		{
		}

		// Token: 0x170009DE RID: 2526
		// (set) Token: 0x060031F7 RID: 12791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009DE")]
		public override EndlessPaymentOptionsListDiscountWindow View
		{
			[Token(Token = "0x60031F7")]
			[Address(RVA = "0x824D", Offset = "0x824D", VA = "0x824D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F8")]
		[Address(RVA = "0x824E", Offset = "0x824E", VA = "0x824E")]
		private void ResetView()
		{
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F9")]
		[Address(RVA = "0x824F", Offset = "0x824F", VA = "0x824F")]
		private void SetupView()
		{
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FA")]
		[Address(RVA = "0x8250", Offset = "0x8250", VA = "0x8250")]
		private void HandleConfirmButtonClickEvent()
		{
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FB")]
		[Address(RVA = "0x8251", Offset = "0x8251", VA = "0x8251")]
		private void ShowListWindow(EndlessPaymentOptionListData listData)
		{
		}
	}
}
