using System;
using Gameplay.AccountLinker.Control;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000DFD RID: 3581
	[Token(Token = "0x2000DFD")]
	public class ConfirmSelectedUserWindow : ClosableBaseWindow<ConfirmSelectedUserWindow.ConfirmSelectedUserWindowArgs>
	{
		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x0600575B RID: 22363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011D0")]
		public override string WindowId
		{
			[Token(Token = "0x600575B")]
			[Address(RVA = "0xA4D6", Offset = "0xA4D6", VA = "0xA4D6", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600575C RID: 22364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575C")]
		[Address(RVA = "0xA4D7", Offset = "0xA4D7", VA = "0xA4D7")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600575D RID: 22365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575D")]
		[Address(RVA = "0xA4D8", Offset = "0xA4D8", VA = "0xA4D8", Slot = "22")]
		protected override void OnShow(ConfirmSelectedUserWindow.ConfirmSelectedUserWindowArgs args)
		{
		}

		// Token: 0x0600575E RID: 22366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575E")]
		[Address(RVA = "0xA4D9", Offset = "0xA4D9", VA = "0xA4D9")]
		public ConfirmSelectedUserWindow()
		{
		}

		// Token: 0x04002F53 RID: 12115
		[Token(Token = "0x4002F53")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/AccountLinker/ConfirmSelectedUserWindow";

		// Token: 0x04002F54 RID: 12116
		[Token(Token = "0x4002F54")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ConfirmSelectedUserView _view;

		// Token: 0x04002F55 RID: 12117
		[Token(Token = "0x4002F55")]
		[FieldOffset(Offset = "0x40")]
		private AccountLinkerConfirmSelectedUserViewMediator _mediator;

		// Token: 0x02000DFE RID: 3582
		[Token(Token = "0x2000DFE")]
		public class ConfirmSelectedUserWindowArgs : BaseWindowArgs
		{
			// Token: 0x0600575F RID: 22367 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600575F")]
			[Address(RVA = "0xA4DA", Offset = "0xA4DA", VA = "0xA4DA")]
			public ConfirmSelectedUserWindowArgs()
			{
			}

			// Token: 0x04002F56 RID: 12118
			[Token(Token = "0x4002F56")]
			[FieldOffset(Offset = "0x18")]
			public AccountLinkerController Controller;
		}
	}
}
