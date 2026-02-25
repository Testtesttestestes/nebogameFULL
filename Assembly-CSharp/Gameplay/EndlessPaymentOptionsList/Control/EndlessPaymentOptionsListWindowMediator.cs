using System;
using Gameplay.EndlessPaymentOptionsList.Model;
using Gameplay.EndlessPaymentOptionsList.View;
using Il2CppDummyDll;
using MVC;
using UnityEngine.EventSystems;

namespace Gameplay.EndlessPaymentOptionsList.Control
{
	// Token: 0x02000852 RID: 2130
	[Token(Token = "0x2000852")]
	public class EndlessPaymentOptionsListWindowMediator : AbstractViewMediator<EndlessPaymentOptionsListModel, EndlessPaymentOptionsListEvents, EndlessPaymentOptionsListController, EndlessPaymentOptionsListWindow>
	{
		// Token: 0x0600321D RID: 12829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600321D")]
		[Address(RVA = "0x8273", Offset = "0x8273", VA = "0x8273")]
		public EndlessPaymentOptionsListWindowMediator(EndlessPaymentOptionsListModel model, EndlessPaymentOptionsListEvents events, EndlessPaymentOptionsListController controller)
		{
		}

		// Token: 0x170009E1 RID: 2529
		// (set) Token: 0x0600321E RID: 12830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E1")]
		public override EndlessPaymentOptionsListEvents Events
		{
			[Token(Token = "0x600321E")]
			[Address(RVA = "0x8274", Offset = "0x8274", VA = "0x8274", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (set) Token: 0x0600321F RID: 12831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E2")]
		public override EndlessPaymentOptionsListWindow View
		{
			[Token(Token = "0x600321F")]
			[Address(RVA = "0x8275", Offset = "0x8275", VA = "0x8275", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003220")]
		[Address(RVA = "0x8276", Offset = "0x8276", VA = "0x8276")]
		private void HandleBuySuccessEvent(CardData removeData, CardData addData)
		{
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003221")]
		[Address(RVA = "0x8277", Offset = "0x8277", VA = "0x8277")]
		private void ResetView()
		{
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003222")]
		[Address(RVA = "0x8278", Offset = "0x8278", VA = "0x8278")]
		private void SetupView()
		{
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003223")]
		[Address(RVA = "0x8279", Offset = "0x8279", VA = "0x8279")]
		private void HandleWindowCloseEvent()
		{
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003224")]
		[Address(RVA = "0x827A", Offset = "0x827A", VA = "0x827A")]
		private void ShowDiscountsForDBG()
		{
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003225")]
		[Address(RVA = "0x827B", Offset = "0x827B", VA = "0x827B")]
		private void DisplayItems()
		{
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003226")]
		[Address(RVA = "0x827C", Offset = "0x827C", VA = "0x827C")]
		private void HandleOptionClickEvent(PointerEventData data)
		{
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003227")]
		[Address(RVA = "0x827D", Offset = "0x827D", VA = "0x827D")]
		private void HandleProcessPurchased(CardData removeData, CardData addData)
		{
		}
	}
}
