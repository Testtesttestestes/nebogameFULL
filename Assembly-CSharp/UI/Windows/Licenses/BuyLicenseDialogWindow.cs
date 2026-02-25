using System;
using Il2CppDummyDll;
using Utils;

namespace UI.Windows.Licenses
{
	// Token: 0x0200029F RID: 671
	[Token(Token = "0x200029F")]
	public static class BuyLicenseDialogWindow
	{
		// Token: 0x06000FB7 RID: 4023 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0x61E0", Offset = "0x61E0", VA = "0x61E0")]
		public static DialogWindow Show()
		{
			return null;
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0x61E1", Offset = "0x61E1", VA = "0x61E1")]
		private static void BuyLicenseCallback(BaseDialogWindow<DialogWindow.DialogWindowArgs> window)
		{
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0x61E2", Offset = "0x61E2", VA = "0x61E2")]
		private static void HandleBuyProcessComplete(OpToken<bool, int> op)
		{
		}
	}
}
