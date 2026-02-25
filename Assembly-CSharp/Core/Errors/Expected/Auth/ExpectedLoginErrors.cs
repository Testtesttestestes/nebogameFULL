using System;
using Il2CppDummyDll;
using Protocol.Auth2;

namespace Core.Errors.Expected.Auth
{
	// Token: 0x02001091 RID: 4241
	[Token(Token = "0x2001091")]
	public static class ExpectedLoginErrors
	{
		// Token: 0x060062B5 RID: 25269 RVA: 0x00012930 File Offset: 0x00010B30
		[Token(Token = "0x60062B5")]
		[Address(RVA = "0xAEDA", Offset = "0xAEDA", VA = "0xAEDA")]
		public static bool TryHandle(LoginCmd.Types.Result errorCode, out bool isCanDoContinueAuthPipeline)
		{
			return default(bool);
		}

		// Token: 0x060062B6 RID: 25270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062B6")]
		[Address(RVA = "0xAEDB", Offset = "0xAEDB", VA = "0xAEDB")]
		private static void HandleTestModeWindowOnClose()
		{
		}

		// Token: 0x060062B7 RID: 25271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062B7")]
		[Address(RVA = "0xAEDC", Offset = "0xAEDC", VA = "0xAEDC")]
		private static void HandleRequiredUpdate()
		{
		}

		// Token: 0x060062B8 RID: 25272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062B8")]
		[Address(RVA = "0xAEDD", Offset = "0xAEDD", VA = "0xAEDD")]
		private static void ShowUserBannedDialogWindow()
		{
		}

		// Token: 0x040034FC RID: 13564
		[Token(Token = "0x40034FC")]
		public const float LOGIN_REQUEST_DELAY = 3f;

		// Token: 0x040034FD RID: 13565
		[Token(Token = "0x40034FD")]
		public const string AUTH_FAILED_CANT_VERIFY_LOCALE_KEY = "AUTH/FAILED/CANT_VERIFY";
	}
}
