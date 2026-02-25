using System;
using Core.Events.Scopes;
using Gameplay.Bank.Model;
using Gameplay.Billing.Controller;
using Gameplay.Billing.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Billing.PurchaseProcess.FewPurchaseMethods
{
	// Token: 0x020011F3 RID: 4595
	[Token(Token = "0x20011F3")]
	public class PurchaseProcess : IPurchaseProcess
	{
		// Token: 0x06006D28 RID: 27944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D28")]
		[Address(RVA = "0xB810", Offset = "0xB810", VA = "0xB810")]
		public PurchaseProcess(uint requirementId, IGame game, IGameRestart gameRestart, AbstractBillingController controller, BillingScope logBillingScope)
		{
		}

		// Token: 0x06006D29 RID: 27945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D29")]
		[Address(RVA = "0xB811", Offset = "0xB811", VA = "0xB811", Slot = "4")]
		public void Run(BankOptionData option)
		{
		}

		// Token: 0x06006D2A RID: 27946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D2A")]
		[Address(RVA = "0xB812", Offset = "0xB812", VA = "0xB812")]
		private void Select(BillingProviderId id, BankOptionData option)
		{
		}

		// Token: 0x06006D2B RID: 27947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D2B")]
		[Address(RVA = "0xB813", Offset = "0xB813", VA = "0xB813")]
		private void ShowSelectFromHvBankToGoogle(BillingProviderId id, BankOptionData option)
		{
		}

		// Token: 0x06006D2C RID: 27948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D2C")]
		[Address(RVA = "0xB814", Offset = "0xB814", VA = "0xB814")]
		private void ShowSelectFromGoogleToHvBank(BillingProviderId id, BankOptionData option)
		{
		}

		// Token: 0x06006D2D RID: 27949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D2D")]
		[Address(RVA = "0xB815", Offset = "0xB815", VA = "0xB815")]
		private void ConfirmSelectBillingCallback(BillingProviderId id, BankOptionData option)
		{
		}

		// Token: 0x0400391D RID: 14621
		[Token(Token = "0x400391D")]
		[FieldOffset(Offset = "0x8")]
		public readonly uint RequirementId;

		// Token: 0x0400391E RID: 14622
		[Token(Token = "0x400391E")]
		[FieldOffset(Offset = "0xC")]
		public readonly IGame Game;

		// Token: 0x0400391F RID: 14623
		[Token(Token = "0x400391F")]
		[FieldOffset(Offset = "0x10")]
		private readonly IGameRestart _gameRestart;

		// Token: 0x04003920 RID: 14624
		[Token(Token = "0x4003920")]
		[FieldOffset(Offset = "0x14")]
		private readonly AbstractBillingController _controller;

		// Token: 0x04003921 RID: 14625
		[Token(Token = "0x4003921")]
		[FieldOffset(Offset = "0x18")]
		private BillingScope _logBillingScope;
	}
}
