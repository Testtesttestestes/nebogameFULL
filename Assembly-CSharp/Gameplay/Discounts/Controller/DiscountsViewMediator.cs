using System;
using Gameplay.Discounts.Events;
using Gameplay.Discounts.Model;
using Gameplay.Discounts.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Discounts.Controller
{
	// Token: 0x020008A6 RID: 2214
	[Token(Token = "0x20008A6")]
	public class DiscountsViewMediator : AbstractViewMediator<DiscountsModel, DiscountsEvents, DiscountsController, DiscountsWindow>
	{
		// Token: 0x06003401 RID: 13313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003401")]
		[Address(RVA = "0x842E", Offset = "0x842E", VA = "0x842E")]
		public DiscountsViewMediator(DiscountsModel model, DiscountsEvents events, DiscountsController controller)
		{
		}

		// Token: 0x17000A4E RID: 2638
		// (set) Token: 0x06003402 RID: 13314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A4E")]
		public override DiscountsWindow View
		{
			[Token(Token = "0x6003402")]
			[Address(RVA = "0x842F", Offset = "0x842F", VA = "0x842F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (set) Token: 0x06003403 RID: 13315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A4F")]
		public override DiscountsEvents Events
		{
			[Token(Token = "0x6003403")]
			[Address(RVA = "0x8430", Offset = "0x8430", VA = "0x8430", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003404")]
		[Address(RVA = "0x8431", Offset = "0x8431", VA = "0x8431")]
		private void DiscountsRequestedEventHandler()
		{
		}
	}
}
