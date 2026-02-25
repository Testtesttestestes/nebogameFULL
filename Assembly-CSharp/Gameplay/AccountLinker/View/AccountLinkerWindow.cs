using System;
using Core.Gameplay;
using Gameplay.AccountLinker.Control;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000DF7 RID: 3575
	[Token(Token = "0x2000DF7")]
	public class AccountLinkerWindow : BaseWindow<AccountLinkerWindow.AccountLinkerWindowArgs>
	{
		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x06005744 RID: 22340 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011CC")]
		public override string WindowId
		{
			[Token(Token = "0x6005744")]
			[Address(RVA = "0xA4BF", Offset = "0xA4BF", VA = "0xA4BF", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005745 RID: 22341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005745")]
		[Address(RVA = "0xA4C0", Offset = "0xA4C0", VA = "0xA4C0", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06005746 RID: 22342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005746")]
		[Address(RVA = "0xA4C1", Offset = "0xA4C1", VA = "0xA4C1", Slot = "22")]
		protected override void OnShow(AccountLinkerWindow.AccountLinkerWindowArgs args)
		{
		}

		// Token: 0x06005747 RID: 22343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005747")]
		[Address(RVA = "0xA4C2", Offset = "0xA4C2", VA = "0xA4C2")]
		public AccountLinkerWindow()
		{
		}

		// Token: 0x04002F47 RID: 12103
		[Token(Token = "0x4002F47")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/AccountLinker/AccountLinkerWindow";

		// Token: 0x04002F48 RID: 12104
		[Token(Token = "0x4002F48")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private AccountLinkerView _view;

		// Token: 0x04002F49 RID: 12105
		[Token(Token = "0x4002F49")]
		[FieldOffset(Offset = "0x38")]
		private AccountLinkerViewMediator _mediator;

		// Token: 0x02000DF8 RID: 3576
		[Token(Token = "0x2000DF8")]
		public class AccountLinkerWindowArgs : BaseWindowArgs
		{
			// Token: 0x06005748 RID: 22344 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005748")]
			[Address(RVA = "0xA4C3", Offset = "0xA4C3", VA = "0xA4C3")]
			public AccountLinkerWindowArgs(IGame game)
			{
			}

			// Token: 0x04002F4A RID: 12106
			[Token(Token = "0x4002F4A")]
			[FieldOffset(Offset = "0x18")]
			public readonly IGame Game;
		}
	}
}
