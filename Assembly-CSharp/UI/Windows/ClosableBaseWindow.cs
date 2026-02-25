using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows
{
	// Token: 0x0200026D RID: 621
	[Token(Token = "0x200026D")]
	public abstract class ClosableBaseWindow<T> : WindowWhitCloseButton<T>, IWindowWithCloseBackButtons where T : BaseWindowArgs
	{
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700020F")]
		public Button BackButton
		{
			[Token(Token = "0x6000EF6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF7")]
		protected override void Awake()
		{
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF8")]
		protected override void OnShow(T args)
		{
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF9")]
		protected override void OnClose()
		{
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFA")]
		protected void OnClickBack()
		{
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFB")]
		protected override void HandleCloseButton()
		{
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFC")]
		protected virtual void HandleBackButton()
		{
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFD")]
		protected ClosableBaseWindow()
		{
		}

		// Token: 0x04000787 RID: 1927
		[Token(Token = "0x4000787")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Button _backButton;
	}
}
