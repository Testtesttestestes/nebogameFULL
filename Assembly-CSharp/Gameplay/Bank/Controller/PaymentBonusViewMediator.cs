using System;
using AssetContent;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C6D RID: 3181
	[Token(Token = "0x2000C6D")]
	public class PaymentBonusViewMediator : AbstractViewMediator<PaymentBonusModel, PaymentBonusEvents, PaymentBonusController, PaymentBonusView>
	{
		// Token: 0x06004DC1 RID: 19905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DC1")]
		[Address(RVA = "0x9BF9", Offset = "0x9BF9", VA = "0x9BF9")]
		public PaymentBonusViewMediator(PaymentBonusModel model, PaymentBonusEvents events, PaymentBonusController controller)
		{
		}

		// Token: 0x17000FBF RID: 4031
		// (set) Token: 0x06004DC2 RID: 19906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FBF")]
		public override PaymentBonusEvents Events
		{
			[Token(Token = "0x6004DC2")]
			[Address(RVA = "0x9BFA", Offset = "0x9BFA", VA = "0x9BFA", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004DC3 RID: 19907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DC3")]
		[Address(RVA = "0x9BFB", Offset = "0x9BFB", VA = "0x9BFB")]
		private void PaymentBonusChangedEvent()
		{
		}

		// Token: 0x17000FC0 RID: 4032
		// (set) Token: 0x06004DC4 RID: 19908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FC0")]
		public override PaymentBonusView View
		{
			[Token(Token = "0x6004DC4")]
			[Address(RVA = "0x9BFC", Offset = "0x9BFC", VA = "0x9BFC", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004DC5 RID: 19909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DC5")]
		[Address(RVA = "0x9BFD", Offset = "0x9BFD", VA = "0x9BFD")]
		private void HandleChestClicked(GameAnimatedButton button)
		{
		}
	}
}
