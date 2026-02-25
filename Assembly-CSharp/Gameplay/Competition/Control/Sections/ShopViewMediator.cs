using System;
using Gameplay.Bank.View;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Gameplay.Competition.View.Sections.Shop;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Control.Sections
{
	// Token: 0x02000910 RID: 2320
	[Token(Token = "0x2000910")]
	public class ShopViewMediator : AbstractCozyViewMediator<ShopModel, ShopEvents, ShopController, ShopView>
	{
		// Token: 0x06003688 RID: 13960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003688")]
		[Address(RVA = "0x8695", Offset = "0x8695", VA = "0x8695")]
		public ShopViewMediator(ShopView view, ShopModel model, ShopEvents events, ShopController controller)
		{
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003689")]
		[Address(RVA = "0x8696", Offset = "0x8696", VA = "0x8696", Slot = "21")]
		protected override void ResetEvents(ShopEvents events)
		{
		}

		// Token: 0x0600368A RID: 13962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600368A")]
		[Address(RVA = "0x8697", Offset = "0x8697", VA = "0x8697", Slot = "22")]
		protected override void SetupEvents(ShopEvents events)
		{
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600368B")]
		[Address(RVA = "0x8698", Offset = "0x8698", VA = "0x8698", Slot = "23")]
		protected override void ResetView(ShopView view)
		{
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600368C")]
		[Address(RVA = "0x8699", Offset = "0x8699", VA = "0x8699", Slot = "24")]
		protected override void SetupView(ShopView view)
		{
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600368D")]
		[Address(RVA = "0x869A", Offset = "0x869A", VA = "0x869A")]
		private void BankOptionsListViewOnBuyButtonClickedEvent(IBankOptionView bankOptionView)
		{
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600368E")]
		[Address(RVA = "0x869B", Offset = "0x869B", VA = "0x869B")]
		private void BankOptionsListViewOnFaqButtonClickedEvent(BankOptionView bankOptionView)
		{
		}
	}
}
