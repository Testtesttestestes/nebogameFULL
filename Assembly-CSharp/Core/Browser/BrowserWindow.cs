using System;
using Il2CppDummyDll;
using UI.Windows;

namespace Core.Browser
{
	// Token: 0x0200110D RID: 4365
	[Token(Token = "0x200110D")]
	public class BrowserWindow : ClosableBaseWindow<BrowserWindow.BrowserWindowArgs>
	{
		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x060065D7 RID: 26071 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170014A2")]
		public override string WindowId
		{
			[Token(Token = "0x60065D7")]
			[Address(RVA = "0xB160", Offset = "0xB160", VA = "0xB160", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060065D8 RID: 26072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065D8")]
		[Address(RVA = "0xB161", Offset = "0xB161", VA = "0xB161")]
		private void OnDestroy()
		{
		}

		// Token: 0x060065D9 RID: 26073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065D9")]
		[Address(RVA = "0xB162", Offset = "0xB162", VA = "0xB162", Slot = "22")]
		protected override void OnShow(BrowserWindow.BrowserWindowArgs args)
		{
		}

		// Token: 0x060065DA RID: 26074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065DA")]
		[Address(RVA = "0xB163", Offset = "0xB163", VA = "0xB163", Slot = "25")]
		protected override void HandleCloseButton()
		{
		}

		// Token: 0x060065DB RID: 26075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065DB")]
		[Address(RVA = "0xB164", Offset = "0xB164", VA = "0xB164", Slot = "29")]
		protected override void HandleBackButton()
		{
		}

		// Token: 0x060065DC RID: 26076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065DC")]
		[Address(RVA = "0xB165", Offset = "0xB165", VA = "0xB165")]
		public BrowserWindow()
		{
		}

		// Token: 0x04003667 RID: 13927
		[Token(Token = "0x4003667")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/BrowserWindow";

		// Token: 0x04003668 RID: 13928
		[Token(Token = "0x4003668")]
		[FieldOffset(Offset = "0x3C")]
		private WebViewObject _webView;

		// Token: 0x0200110E RID: 4366
		[Token(Token = "0x200110E")]
		public class BrowserWindowArgs : BaseWindowArgs
		{
			// Token: 0x060065DD RID: 26077 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60065DD")]
			[Address(RVA = "0xB166", Offset = "0xB166", VA = "0xB166")]
			public BrowserWindowArgs(Uri uri)
			{
			}

			// Token: 0x04003669 RID: 13929
			[Token(Token = "0x4003669")]
			[FieldOffset(Offset = "0x18")]
			public readonly Uri Uri;
		}
	}
}
