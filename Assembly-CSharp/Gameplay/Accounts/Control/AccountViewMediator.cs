using System;
using System.Collections.Generic;
using Gameplay.Accounts.Model;
using Gameplay.Accounts.Model.Data;
using Gameplay.Accounts.View;
using Gameplay.Accounts.View.Accounts;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Accounts.Control
{
	// Token: 0x02000DE4 RID: 3556
	[Token(Token = "0x2000DE4")]
	public class AccountViewMediator : AbstractCozyViewMediator<AccountsModel, AccountsEvents, AccountsController, DefaultAccountView>
	{
		// Token: 0x060056C9 RID: 22217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C9")]
		[Address(RVA = "0xA448", Offset = "0xA448", VA = "0xA448", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x060056CA RID: 22218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CA")]
		[Address(RVA = "0xA449", Offset = "0xA449", VA = "0xA449")]
		public AccountViewMediator(DefaultAccountView view, AccountsModel model, AccountsEvents events, AccountsController controller)
		{
		}

		// Token: 0x060056CB RID: 22219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CB")]
		[Address(RVA = "0xA44A", Offset = "0xA44A", VA = "0xA44A", Slot = "21")]
		protected override void ResetEvents(AccountsEvents events)
		{
		}

		// Token: 0x060056CC RID: 22220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CC")]
		[Address(RVA = "0xA44B", Offset = "0xA44B", VA = "0xA44B", Slot = "22")]
		protected override void SetupEvents(AccountsEvents events)
		{
		}

		// Token: 0x060056CD RID: 22221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CD")]
		[Address(RVA = "0xA44C", Offset = "0xA44C", VA = "0xA44C", Slot = "23")]
		protected override void ResetView(DefaultAccountView view)
		{
		}

		// Token: 0x060056CE RID: 22222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CE")]
		[Address(RVA = "0xA44D", Offset = "0xA44D", VA = "0xA44D", Slot = "24")]
		protected override void SetupView(DefaultAccountView view)
		{
		}

		// Token: 0x060056CF RID: 22223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CF")]
		[Address(RVA = "0xA44E", Offset = "0xA44E", VA = "0xA44E")]
		private void HandleAccountStickerChangedEvent(IList<IAccountDataDecorator> list)
		{
		}

		// Token: 0x060056D0 RID: 22224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D0")]
		[Address(RVA = "0xA44F", Offset = "0xA44F", VA = "0xA44F")]
		private void HandleAccountChangedEvent(IAccountDataDecorator account)
		{
		}

		// Token: 0x060056D1 RID: 22225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D1")]
		[Address(RVA = "0xA450", Offset = "0xA450", VA = "0xA450")]
		private void ValidateActivation(IAccountDataDecorator account)
		{
		}

		// Token: 0x060056D2 RID: 22226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D2")]
		[Address(RVA = "0xA451", Offset = "0xA451", VA = "0xA451")]
		private void DisplayOptionsButtons(List<AccountOptionData> options)
		{
		}

		// Token: 0x060056D3 RID: 22227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D3")]
		[Address(RVA = "0xA452", Offset = "0xA452", VA = "0xA452")]
		private void RemoveOptionsButtons(List<OptionBuyButtonItem> optionButtons)
		{
		}

		// Token: 0x060056D4 RID: 22228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D4")]
		[Address(RVA = "0xA453", Offset = "0xA453", VA = "0xA453")]
		private void HandleOptionClickEvent(OptionBuyButtonItem optionView)
		{
		}

		// Token: 0x04002EFD RID: 12029
		[Token(Token = "0x4002EFD")]
		public const string LOCALIZATION_ACTION_TITLE_ACTIVATE = "ACCOUNT/ACTION_TITLE/ACTIVATE";

		// Token: 0x04002EFE RID: 12030
		[Token(Token = "0x4002EFE")]
		public const string LOCALIZATION_ACTION_TITLE_EXTEND = "ACCOUNT/ACTION_TITLE/EXTEND";

		// Token: 0x04002EFF RID: 12031
		[Token(Token = "0x4002EFF")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<OptionBuyButtonItem> _optionBuyButtonItems;
	}
}
