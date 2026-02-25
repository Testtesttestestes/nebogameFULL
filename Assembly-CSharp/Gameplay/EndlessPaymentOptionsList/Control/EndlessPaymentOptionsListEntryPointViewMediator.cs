using System;
using Gameplay.EndlessPaymentOptionsList.Model;
using Gameplay.EndlessPaymentOptionsList.View;
using Il2CppDummyDll;
using MVC;
using UI;

namespace Gameplay.EndlessPaymentOptionsList.Control
{
	// Token: 0x02000851 RID: 2129
	[Token(Token = "0x2000851")]
	public class EndlessPaymentOptionsListEntryPointViewMediator : AbstractViewMediator<EndlessPaymentOptionsListModel, EndlessPaymentOptionsListEvents, EndlessPaymentOptionsListController, EndlessPaymentOptionsListEntryPointView>
	{
		// Token: 0x06003212 RID: 12818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003212")]
		[Address(RVA = "0x8268", Offset = "0x8268", VA = "0x8268")]
		public EndlessPaymentOptionsListEntryPointViewMediator(EndlessPaymentOptionsListModel model, EndlessPaymentOptionsListEvents events, EndlessPaymentOptionsListController controller)
		{
		}

		// Token: 0x170009DF RID: 2527
		// (set) Token: 0x06003213 RID: 12819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009DF")]
		public override EndlessPaymentOptionsListEntryPointView View
		{
			[Token(Token = "0x6003213")]
			[Address(RVA = "0x8269", Offset = "0x8269", VA = "0x8269", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (set) Token: 0x06003214 RID: 12820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E0")]
		public override EndlessPaymentOptionsListEvents Events
		{
			[Token(Token = "0x6003214")]
			[Address(RVA = "0x826A", Offset = "0x826A", VA = "0x826A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003215")]
		[Address(RVA = "0x826B", Offset = "0x826B", VA = "0x826B")]
		private void HandleOptionsRequestedEvent()
		{
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003216")]
		[Address(RVA = "0x826C", Offset = "0x826C", VA = "0x826C")]
		private void HandleBuySuccessEvent(CardData a, CardData b)
		{
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003217")]
		[Address(RVA = "0x826D", Offset = "0x826D", VA = "0x826D")]
		private void HandleOptionsListTimeOutEvent()
		{
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003218")]
		[Address(RVA = "0x826E", Offset = "0x826E", VA = "0x826E")]
		private void SetupView()
		{
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003219")]
		[Address(RVA = "0x826F", Offset = "0x826F", VA = "0x826F")]
		private void ResetView()
		{
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x0000A3E0 File Offset: 0x000085E0
		[Token(Token = "0x600321A")]
		[Address(RVA = "0x8270", Offset = "0x8270", VA = "0x8270")]
		private bool TryShowEntryPoint()
		{
			return default(bool);
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600321B")]
		[Address(RVA = "0x8271", Offset = "0x8271", VA = "0x8271")]
		private void HandleClickEvent(IndexButtonBasic obj)
		{
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600321C")]
		[Address(RVA = "0x8272", Offset = "0x8272", VA = "0x8272")]
		private void ShowListWindow()
		{
		}
	}
}
