using System;
using Gameplay.AccountLinker.Model;
using Gameplay.AccountLinker.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.AccountLinker.Control
{
	// Token: 0x02000E20 RID: 3616
	[Token(Token = "0x2000E20")]
	public class AccountLinkerSelectUserViewMediator : AbstractViewMediator<AccountLinkerModel, AccountLinkerEvents, AccountLinkerController, SelectUserView>
	{
		// Token: 0x0600582A RID: 22570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600582A")]
		[Address(RVA = "0xA599", Offset = "0xA599", VA = "0xA599", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x0600582B RID: 22571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600582B")]
		[Address(RVA = "0xA59A", Offset = "0xA59A", VA = "0xA59A")]
		public AccountLinkerSelectUserViewMediator(AccountLinkerModel model, AccountLinkerEvents events, AccountLinkerController controller)
		{
		}

		// Token: 0x170011F4 RID: 4596
		// (set) Token: 0x0600582C RID: 22572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011F4")]
		public override AccountLinkerEvents Events
		{
			[Token(Token = "0x600582C")]
			[Address(RVA = "0xA59B", Offset = "0xA59B", VA = "0xA59B", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170011F5 RID: 4597
		// (set) Token: 0x0600582D RID: 22573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011F5")]
		public override SelectUserView View
		{
			[Token(Token = "0x600582D")]
			[Address(RVA = "0xA59C", Offset = "0xA59C", VA = "0xA59C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600582E RID: 22574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600582E")]
		[Address(RVA = "0xA59D", Offset = "0xA59D", VA = "0xA59D")]
		private void HandleSetUserSuccessEvent()
		{
		}

		// Token: 0x0600582F RID: 22575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600582F")]
		[Address(RVA = "0xA59E", Offset = "0xA59E", VA = "0xA59E")]
		private void HandleOnSelectUser(LinkerUser user)
		{
		}

		// Token: 0x06005830 RID: 22576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005830")]
		[Address(RVA = "0xA59F", Offset = "0xA59F", VA = "0xA59F")]
		private void HandleSetupView()
		{
		}

		// Token: 0x06005831 RID: 22577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005831")]
		[Address(RVA = "0xA5A0", Offset = "0xA5A0", VA = "0xA5A0")]
		private void ShowConfirmSelectedUserWindow()
		{
		}

		// Token: 0x06005832 RID: 22578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005832")]
		[Address(RVA = "0xA5A1", Offset = "0xA5A1", VA = "0xA5A1")]
		private void HandleOnCloseConfirmSelectedUserWindow()
		{
		}

		// Token: 0x06005833 RID: 22579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005833")]
		[Address(RVA = "0xA5A2", Offset = "0xA5A2", VA = "0xA5A2")]
		private void CloseConfirmSelectedUserWindow()
		{
		}

		// Token: 0x04002FC4 RID: 12228
		[Token(Token = "0x4002FC4")]
		[FieldOffset(Offset = "0x18")]
		private ConfirmSelectedUserWindow _confirmSelectedUserWindow;
	}
}
