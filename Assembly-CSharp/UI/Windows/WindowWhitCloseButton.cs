using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows
{
	// Token: 0x02000282 RID: 642
	[Token(Token = "0x2000282")]
	public abstract class WindowWhitCloseButton<T> : BaseWindow<T> where T : BaseWindowArgs
	{
		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700021E")]
		public Button CloseButton
		{
			[Token(Token = "0x6000F43")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F44")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F45")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F46")]
		protected override void OnClose()
		{
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F47")]
		protected override void OnShow(T args)
		{
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F48")]
		private void OnClickClose()
		{
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F49")]
		protected virtual void HandleCloseButton()
		{
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4A")]
		protected WindowWhitCloseButton()
		{
		}

		// Token: 0x040007BF RID: 1983
		[Token(Token = "0x40007BF")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Button _closeButton;
	}
}
