using System;
using Gameplay.Accounts.Model;
using Gameplay.Accounts.View;
using Il2CppDummyDll;
using MVC;
using UI;

namespace Gameplay.Accounts.Control
{
	// Token: 0x02000DE3 RID: 3555
	[Token(Token = "0x2000DE3")]
	public class AccountEntryPointViewMediator : AbstractViewMediator<AccountsModel, AccountsEvents, AccountsController, AccountsButtonView>
	{
		// Token: 0x060056C2 RID: 22210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C2")]
		[Address(RVA = "0xA441", Offset = "0xA441", VA = "0xA441")]
		public AccountEntryPointViewMediator(AccountsModel model, AccountsEvents events, AccountsController controller)
		{
		}

		// Token: 0x170011B6 RID: 4534
		// (set) Token: 0x060056C3 RID: 22211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011B6")]
		public override AccountsEvents Events
		{
			[Token(Token = "0x60056C3")]
			[Address(RVA = "0xA442", Offset = "0xA442", VA = "0xA442", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170011B7 RID: 4535
		// (set) Token: 0x060056C4 RID: 22212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011B7")]
		public override AccountsButtonView View
		{
			[Token(Token = "0x60056C4")]
			[Address(RVA = "0xA443", Offset = "0xA443", VA = "0xA443", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060056C5 RID: 22213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C5")]
		[Address(RVA = "0xA444", Offset = "0xA444", VA = "0xA444")]
		private void ResetView()
		{
		}

		// Token: 0x060056C6 RID: 22214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C6")]
		[Address(RVA = "0xA445", Offset = "0xA445", VA = "0xA445")]
		private void SetupView()
		{
		}

		// Token: 0x060056C7 RID: 22215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C7")]
		[Address(RVA = "0xA446", Offset = "0xA446", VA = "0xA446")]
		private void EpNotificationsOnNotificationsCountChangedEvent(int value)
		{
		}

		// Token: 0x060056C8 RID: 22216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C8")]
		[Address(RVA = "0xA447", Offset = "0xA447", VA = "0xA447")]
		private void HandleClickEvent(IndexButtonBasic btn)
		{
		}
	}
}
