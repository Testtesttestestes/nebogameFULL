using System;
using Gameplay.AccountLinker.Model;
using Gameplay.AccountLinker.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.AccountLinker.Control
{
	// Token: 0x02000E18 RID: 3608
	[Token(Token = "0x2000E18")]
	public class AccountLinkerConfirmSelectedUserViewMediator : AbstractViewMediator<AccountLinkerModel, AccountLinkerEvents, AccountLinkerController, ConfirmSelectedUserView>
	{
		// Token: 0x060057F4 RID: 22516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F4")]
		[Address(RVA = "0xA566", Offset = "0xA566", VA = "0xA566")]
		public AccountLinkerConfirmSelectedUserViewMediator(AccountLinkerModel model, AccountLinkerEvents events, AccountLinkerController controller)
		{
		}

		// Token: 0x170011F2 RID: 4594
		// (set) Token: 0x060057F5 RID: 22517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011F2")]
		public override ConfirmSelectedUserView View
		{
			[Token(Token = "0x60057F5")]
			[Address(RVA = "0xA567", Offset = "0xA567", VA = "0xA567", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060057F6 RID: 22518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F6")]
		[Address(RVA = "0xA568", Offset = "0xA568", VA = "0xA568")]
		private void SetupView()
		{
		}

		// Token: 0x060057F7 RID: 22519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F7")]
		[Address(RVA = "0xA569", Offset = "0xA569", VA = "0xA569")]
		private void HandleOnSelectEvent(LinkerUser user)
		{
		}
	}
}
