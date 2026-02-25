using System;
using System.Collections.Generic;
using Gameplay.Accounts.Clan.Model;
using Gameplay.Accounts.Clan.View;
using Gameplay.Accounts.Model.Data;
using Gameplay.Accounts.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Accounts.Clan.Control
{
	// Token: 0x02000DF1 RID: 3569
	[Token(Token = "0x2000DF1")]
	public class ClanAccountViewMediator : AbstractViewMediator<ClanAccountModel, AccountsEvents, ClanAccountController, ClanAccountView>
	{
		// Token: 0x0600571B RID: 22299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600571B")]
		[Address(RVA = "0xA497", Offset = "0xA497", VA = "0xA497", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x0600571C RID: 22300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600571C")]
		[Address(RVA = "0xA498", Offset = "0xA498", VA = "0xA498")]
		public ClanAccountViewMediator(ClanAccountModel model, AccountsEvents events, ClanAccountController controller)
		{
		}

		// Token: 0x170011C3 RID: 4547
		// (set) Token: 0x0600571D RID: 22301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011C3")]
		public override ClanAccountView View
		{
			[Token(Token = "0x600571D")]
			[Address(RVA = "0xA499", Offset = "0xA499", VA = "0xA499", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170011C4 RID: 4548
		// (set) Token: 0x0600571E RID: 22302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011C4")]
		public override AccountsEvents Events
		{
			[Token(Token = "0x600571E")]
			[Address(RVA = "0xA49A", Offset = "0xA49A", VA = "0xA49A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600571F RID: 22303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600571F")]
		[Address(RVA = "0xA49B", Offset = "0xA49B", VA = "0xA49B")]
		private void HandleAccountChangedEvent(IAccountDataDecorator account)
		{
		}

		// Token: 0x06005720 RID: 22304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005720")]
		[Address(RVA = "0xA49C", Offset = "0xA49C", VA = "0xA49C")]
		private void HandleTabSelectedEvent(ClanAccountTabView tab)
		{
		}

		// Token: 0x06005721 RID: 22305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005721")]
		[Address(RVA = "0xA49D", Offset = "0xA49D", VA = "0xA49D")]
		private void SetupView()
		{
		}

		// Token: 0x06005722 RID: 22306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005722")]
		[Address(RVA = "0x1D58", Offset = "0x1D58", VA = "0x1D58")]
		private void UpdateStatusText()
		{
		}

		// Token: 0x06005723 RID: 22307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005723")]
		[Address(RVA = "0xA49E", Offset = "0xA49E", VA = "0xA49E")]
		private void DisplayAccountInformation(ClanAccount account)
		{
		}

		// Token: 0x06005724 RID: 22308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005724")]
		[Address(RVA = "0xA49F", Offset = "0xA49F", VA = "0xA49F")]
		private void DisplayOptionsButtons(List<AccountOptionData> options)
		{
		}

		// Token: 0x06005725 RID: 22309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005725")]
		[Address(RVA = "0xA4A0", Offset = "0xA4A0", VA = "0xA4A0")]
		private void RemoveOptionsButtons(List<OptionBuyButtonItem> optionButtons)
		{
		}

		// Token: 0x06005726 RID: 22310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005726")]
		[Address(RVA = "0xA4A1", Offset = "0xA4A1", VA = "0xA4A1")]
		private void HandleOptionClickEvent(OptionBuyButtonItem view)
		{
		}

		// Token: 0x04002F26 RID: 12070
		[Token(Token = "0x4002F26")]
		[FieldOffset(Offset = "0x18")]
		private List<OptionBuyButtonItem> _optionBuyButtonItems;
	}
}
