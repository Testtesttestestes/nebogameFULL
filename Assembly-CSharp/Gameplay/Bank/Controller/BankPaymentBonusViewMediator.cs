using System;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C66 RID: 3174
	[Token(Token = "0x2000C66")]
	public class BankPaymentBonusViewMediator : AbstractViewMediator<PaymentBonusModel, PaymentBonusEvents, PaymentBonusController, BankPaymentBonusView>
	{
		// Token: 0x06004D8E RID: 19854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D8E")]
		[Address(RVA = "0x9BC6", Offset = "0x9BC6", VA = "0x9BC6")]
		public BankPaymentBonusViewMediator(PaymentBonusModel model, PaymentBonusEvents events, PaymentBonusController controller)
		{
		}

		// Token: 0x17000FB5 RID: 4021
		// (set) Token: 0x06004D8F RID: 19855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FB5")]
		public override PaymentBonusEvents Events
		{
			[Token(Token = "0x6004D8F")]
			[Address(RVA = "0x9BC7", Offset = "0x9BC7", VA = "0x9BC7", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D90")]
		[Address(RVA = "0x9BC8", Offset = "0x9BC8", VA = "0x9BC8")]
		private void PaymentBonusChangedEvent()
		{
		}

		// Token: 0x17000FB6 RID: 4022
		// (set) Token: 0x06004D91 RID: 19857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FB6")]
		public override BankPaymentBonusView View
		{
			[Token(Token = "0x6004D91")]
			[Address(RVA = "0x9BC9", Offset = "0x9BC9", VA = "0x9BC9", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D92")]
		[Address(RVA = "0x9BCA", Offset = "0x9BCA", VA = "0x9BCA")]
		private void DisplayCurrentPaymentBonus()
		{
		}
	}
}
