using System;
using Gameplay.AccountLinker.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000E01 RID: 3585
	[Token(Token = "0x2000E01")]
	public class SelectUserProcessSuccessWindow : BaseDialogWindow<SelectUserProcessSuccessWindow.Args>
	{
		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06005765 RID: 22373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011D1")]
		public override string WindowId
		{
			[Token(Token = "0x6005765")]
			[Address(RVA = "0xA4E0", Offset = "0xA4E0", VA = "0xA4E0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005766 RID: 22374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005766")]
		[Address(RVA = "0xA4E1", Offset = "0xA4E1", VA = "0xA4E1", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06005767 RID: 22375 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005767")]
		[Address(RVA = "0xA4E2", Offset = "0xA4E2", VA = "0xA4E2")]
		public static SelectUserProcessSuccessWindow Show(LinkerUser user)
		{
			return null;
		}

		// Token: 0x06005768 RID: 22376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005768")]
		[Address(RVA = "0xA4E3", Offset = "0xA4E3", VA = "0xA4E3")]
		public SelectUserProcessSuccessWindow()
		{
		}

		// Token: 0x04002F58 RID: 12120
		[Token(Token = "0x4002F58")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/AccountLinker/SelectUserProcessSuccessDialogWindow";

		// Token: 0x04002F59 RID: 12121
		[Token(Token = "0x4002F59")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AccountLinkerUserView _widget;

		// Token: 0x02000E02 RID: 3586
		[Token(Token = "0x2000E02")]
		public class Args : BaseDialogWindow<SelectUserProcessSuccessWindow.Args>.BaseDialogWindowArgs
		{
			// Token: 0x06005769 RID: 22377 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005769")]
			[Address(RVA = "0xA4E4", Offset = "0xA4E4", VA = "0xA4E4")]
			public Args(LinkerUser user)
			{
			}

			// Token: 0x04002F5A RID: 12122
			[Token(Token = "0x4002F5A")]
			[FieldOffset(Offset = "0x2C")]
			public LinkerUser User;
		}
	}
}
