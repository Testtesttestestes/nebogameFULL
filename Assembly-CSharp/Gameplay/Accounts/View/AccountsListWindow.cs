using System;
using Gameplay.Accounts.Control;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Accounts.View
{
	// Token: 0x02000DCB RID: 3531
	[Token(Token = "0x2000DCB")]
	public class AccountsListWindow : ClosableBaseWindow<AccountsListWindow.AccountsListWindowsArgs>
	{
		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x06005622 RID: 22050 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001182")]
		public override string WindowId
		{
			[Token(Token = "0x6005622")]
			[Address(RVA = "0xA3C0", Offset = "0xA3C0", VA = "0xA3C0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005623 RID: 22051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005623")]
		[Address(RVA = "0xA3C1", Offset = "0xA3C1", VA = "0xA3C1", Slot = "22")]
		protected override void OnShow(AccountsListWindow.AccountsListWindowsArgs args)
		{
		}

		// Token: 0x06005624 RID: 22052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005624")]
		[Address(RVA = "0xA3C2", Offset = "0xA3C2", VA = "0xA3C2", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06005625 RID: 22053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005625")]
		[Address(RVA = "0xA3C3", Offset = "0xA3C3", VA = "0xA3C3")]
		public AccountsListWindow()
		{
		}

		// Token: 0x04002EB8 RID: 11960
		[Token(Token = "0x4002EB8")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Accounts/AccountsListWindow";

		// Token: 0x04002EB9 RID: 11961
		[Token(Token = "0x4002EB9")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private AccountsListView _view;

		// Token: 0x04002EBA RID: 11962
		[Token(Token = "0x4002EBA")]
		[FieldOffset(Offset = "0x40")]
		private AccountsListViewMediator _mediator;

		// Token: 0x02000DCC RID: 3532
		[Token(Token = "0x2000DCC")]
		public class AccountsListWindowsArgs : BaseWindowArgs
		{
			// Token: 0x06005626 RID: 22054 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005626")]
			[Address(RVA = "0xA3C4", Offset = "0xA3C4", VA = "0xA3C4")]
			public AccountsListWindowsArgs()
			{
			}

			// Token: 0x04002EBB RID: 11963
			[Token(Token = "0x4002EBB")]
			[FieldOffset(Offset = "0x18")]
			public AccountsController Controller;
		}
	}
}
