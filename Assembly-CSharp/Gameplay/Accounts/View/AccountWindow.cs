using System;
using System.Collections.Generic;
using Gameplay.Accounts.Control;
using Gameplay.Accounts.Model.Data;
using Gameplay.Accounts.View.Accounts;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Accounts.View
{
	// Token: 0x02000DC5 RID: 3525
	[Token(Token = "0x2000DC5")]
	public class AccountWindow : ClosableBaseWindow<AccountWindow.AccountWindowArgs>
	{
		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x06005602 RID: 22018 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700117B")]
		public override string WindowId
		{
			[Token(Token = "0x6005602")]
			[Address(RVA = "0xA3A2", Offset = "0xA3A2", VA = "0xA3A2", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005603 RID: 22019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005603")]
		[Address(RVA = "0xA3A3", Offset = "0xA3A3", VA = "0xA3A3", Slot = "24")]
		protected override void Awake()
		{
		}

		// Token: 0x06005604 RID: 22020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005604")]
		[Address(RVA = "0xA3A4", Offset = "0xA3A4", VA = "0xA3A4", Slot = "22")]
		protected override void OnShow(AccountWindow.AccountWindowArgs args)
		{
		}

		// Token: 0x06005605 RID: 22021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005605")]
		[Address(RVA = "0xA3A5", Offset = "0xA3A5", VA = "0xA3A5")]
		public AccountWindow()
		{
		}

		// Token: 0x04002E9B RID: 11931
		[Token(Token = "0x4002E9B")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Accounts/AccountWindow";

		// Token: 0x04002E9C RID: 11932
		[Token(Token = "0x4002E9C")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Transform _viewContainer;

		// Token: 0x04002E9D RID: 11933
		[Token(Token = "0x4002E9D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DefaultAccountView _defaultViewPrefab;

		// Token: 0x04002E9E RID: 11934
		[Token(Token = "0x4002E9E")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private DefaultAccountView _manufactureViewPrefab;

		// Token: 0x04002E9F RID: 11935
		[Token(Token = "0x4002E9F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AbstractAccountView _clanViewPrefab;

		// Token: 0x04002EA0 RID: 11936
		[Token(Token = "0x4002EA0")]
		[FieldOffset(Offset = "0x4C")]
		private Dictionary<Type, AbstractAccountView> _map;

		// Token: 0x02000DC6 RID: 3526
		[Token(Token = "0x2000DC6")]
		public class AccountWindowArgs : BaseWindowArgs
		{
			// Token: 0x06005606 RID: 22022 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005606")]
			[Address(RVA = "0xA3A6", Offset = "0xA3A6", VA = "0xA3A6")]
			public AccountWindowArgs()
			{
			}

			// Token: 0x04002EA1 RID: 11937
			[Token(Token = "0x4002EA1")]
			[FieldOffset(Offset = "0x18")]
			public AccountsController Controller;

			// Token: 0x04002EA2 RID: 11938
			[Token(Token = "0x4002EA2")]
			[FieldOffset(Offset = "0x1C")]
			public IAccountDataDecorator Account;
		}
	}
}
