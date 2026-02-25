using System;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C65 RID: 3173
	[Token(Token = "0x2000C65")]
	public class BankOptionInfoWindowMediator : AbstractViewMediator<BankModel, BankEvents, BankController, BankOptionInfoWindow>
	{
		// Token: 0x06004D85 RID: 19845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D85")]
		[Address(RVA = "0x9BBD", Offset = "0x9BBD", VA = "0x9BBD")]
		public BankOptionInfoWindowMediator(BankModel model, BankEvents events, BankController controller)
		{
		}

		// Token: 0x17000FB3 RID: 4019
		// (set) Token: 0x06004D86 RID: 19846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FB3")]
		public override BankEvents Events
		{
			[Token(Token = "0x6004D86")]
			[Address(RVA = "0x9BBE", Offset = "0x9BBE", VA = "0x9BBE", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004D87 RID: 19847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D87")]
		[Address(RVA = "0x9BBF", Offset = "0x9BBF", VA = "0x9BBF")]
		private void OptionArtikulsReceivedEvent(uint optionId)
		{
		}

		// Token: 0x06004D88 RID: 19848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D88")]
		[Address(RVA = "0x9BC0", Offset = "0x9BC0", VA = "0x9BC0")]
		private void DisplayCurrentContainer()
		{
		}

		// Token: 0x17000FB4 RID: 4020
		// (set) Token: 0x06004D89 RID: 19849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FB4")]
		public override BankOptionInfoWindow View
		{
			[Token(Token = "0x6004D89")]
			[Address(RVA = "0x9BC1", Offset = "0x9BC1", VA = "0x9BC1", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D8A")]
		[Address(RVA = "0x9BC2", Offset = "0x9BC2", VA = "0x9BC2")]
		private void BankOptionViewOnBuyButtonClickEvent(IBankOptionView bankOptionView)
		{
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D8B")]
		[Address(RVA = "0x9BC3", Offset = "0x9BC3", VA = "0x9BC3")]
		private void PrevButtonClickHandler()
		{
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D8C")]
		[Address(RVA = "0x9BC4", Offset = "0x9BC4", VA = "0x9BC4")]
		private void NextButtonClickHandler()
		{
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D8D")]
		[Address(RVA = "0x9BC5", Offset = "0x9BC5", VA = "0x9BC5", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04002A45 RID: 10821
		[Token(Token = "0x4002A45")]
		[FieldOffset(Offset = "0x18")]
		private int _currentIndex;
	}
}
