using System;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Billing.View
{
	// Token: 0x02000BDF RID: 3039
	[Token(Token = "0x2000BDF")]
	public class HeavensBankWindow : ClosableBaseWindow<HeavensBankWindow.HeavensBankWindowArgs>
	{
		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06004A99 RID: 19097 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F0E")]
		public override string WindowId
		{
			[Token(Token = "0x6004A99")]
			[Address(RVA = "0x98FB", Offset = "0x98FB", VA = "0x98FB", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004A9A RID: 19098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A9A")]
		[Address(RVA = "0x98FC", Offset = "0x98FC", VA = "0x98FC")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004A9B RID: 19099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A9B")]
		[Address(RVA = "0x98FD", Offset = "0x98FD", VA = "0x98FD", Slot = "22")]
		protected override void OnShow(HeavensBankWindow.HeavensBankWindowArgs args)
		{
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A9C")]
		[Address(RVA = "0x98FE", Offset = "0x98FE", VA = "0x98FE", Slot = "25")]
		protected override void HandleCloseButton()
		{
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A9D")]
		[Address(RVA = "0x98FF", Offset = "0x98FF", VA = "0x98FF", Slot = "29")]
		protected override void HandleBackButton()
		{
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A9E")]
		[Address(RVA = "0x9900", Offset = "0x9900", VA = "0x9900")]
		public HeavensBankWindow()
		{
		}

		// Token: 0x04002895 RID: 10389
		[Token(Token = "0x4002895")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Bank/HeavensBankWindow";

		// Token: 0x04002896 RID: 10390
		[Token(Token = "0x4002896")]
		[FieldOffset(Offset = "0x3C")]
		private WebViewObject _webView;

		// Token: 0x02000BE0 RID: 3040
		[Token(Token = "0x2000BE0")]
		public class HeavensBankWindowArgs : BaseWindowArgs
		{
			// Token: 0x06004A9F RID: 19103 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004A9F")]
			[Address(RVA = "0x9901", Offset = "0x9901", VA = "0x9901")]
			public HeavensBankWindowArgs(Uri uri)
			{
			}

			// Token: 0x04002897 RID: 10391
			[Token(Token = "0x4002897")]
			[FieldOffset(Offset = "0x18")]
			public readonly Uri Uri;
		}
	}
}
