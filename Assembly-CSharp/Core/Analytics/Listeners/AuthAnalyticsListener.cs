using System;
using Core.Events.Scopes;
using Il2CppDummyDll;
using Protocol.Auth2;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C2 RID: 4802
	[Token(Token = "0x20012C2")]
	public class AuthAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x06007208 RID: 29192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001726")]
		protected override string Theme
		{
			[Token(Token = "0x6007208")]
			[Address(RVA = "0xBC11", Offset = "0xBC11", VA = "0xBC11", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007209 RID: 29193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007209")]
		[Address(RVA = "0xBC12", Offset = "0xBC12", VA = "0xBC12", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x0600720A RID: 29194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600720A")]
		[Address(RVA = "0xBC13", Offset = "0xBC13", VA = "0xBC13", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x0600720B RID: 29195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600720B")]
		[Address(RVA = "0xBC14", Offset = "0xBC14", VA = "0xBC14")]
		private void LoginErrorEvent(AuthScope.LoginErrorEventArgs e)
		{
		}

		// Token: 0x0600720C RID: 29196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600720C")]
		[Address(RVA = "0xBC15", Offset = "0xBC15", VA = "0xBC15")]
		private void RegistrationErrorEvent(AuthScope.RegisterErrorEventArgs e)
		{
		}

		// Token: 0x0600720D RID: 29197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600720D")]
		[Address(RVA = "0xBC16", Offset = "0xBC16", VA = "0xBC16")]
		private void RegistrationRequestEvent(AuthScope.RegistrationRequestEventArgs e)
		{
		}

		// Token: 0x0600720E RID: 29198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600720E")]
		[Address(RVA = "0xBC17", Offset = "0xBC17", VA = "0xBC17")]
		private void UserIdChangedEvent(AuthScope.BaseAuthEventArgs e)
		{
		}

		// Token: 0x0600720F RID: 29199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600720F")]
		[Address(RVA = "0xBC18", Offset = "0xBC18", VA = "0xBC18")]
		private void RegisterEvent(AuthScope.BaseAuthEventArgs e)
		{
		}

		// Token: 0x06007210 RID: 29200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007210")]
		[Address(RVA = "0xBC19", Offset = "0xBC19", VA = "0xBC19")]
		private void LoginEvent(AuthScope.BaseAuthEventArgs e)
		{
		}

		// Token: 0x06007211 RID: 29201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007211")]
		[Address(RVA = "0xBC1A", Offset = "0xBC1A", VA = "0xBC1A")]
		private void SetIsTester(bool value)
		{
		}

		// Token: 0x06007212 RID: 29202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007212")]
		[Address(RVA = "0xBC1B", Offset = "0xBC1B", VA = "0xBC1B")]
		private void SyncAccountProcessStartEvent(AuthScope.SyncAccountEventArgs e)
		{
		}

		// Token: 0x06007213 RID: 29203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007213")]
		[Address(RVA = "0xBC1C", Offset = "0xBC1C", VA = "0xBC1C")]
		private void SyncAccountProcessCompleteEvent(AuthScope.SyncAccountEventArgs e)
		{
		}

		// Token: 0x06007214 RID: 29204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007214")]
		[Address(RVA = "0xBC1D", Offset = "0xBC1D", VA = "0xBC1D")]
		public AuthAnalyticsListener()
		{
		}

		// Token: 0x04003BC0 RID: 15296
		[Token(Token = "0x4003BC0")]
		public const string THEME = "auth";

		// Token: 0x04003BC1 RID: 15297
		[Token(Token = "0x4003BC1")]
		public const string LOGIN = "login";

		// Token: 0x04003BC2 RID: 15298
		[Token(Token = "0x4003BC2")]
		public const string LOGIN_ERROR = "login_error";

		// Token: 0x04003BC3 RID: 15299
		[Token(Token = "0x4003BC3")]
		public const string OLD_CLIENT_LOGIN_ERROR = "old_client_login_error";

		// Token: 0x04003BC4 RID: 15300
		[Token(Token = "0x4003BC4")]
		public const string REGISTRATION = "registration";

		// Token: 0x04003BC5 RID: 15301
		[Token(Token = "0x4003BC5")]
		public const string REGISTRATION_REQUEST = "registration_request";

		// Token: 0x04003BC6 RID: 15302
		[Token(Token = "0x4003BC6")]
		public const string REGISTRATION_ERROR = "registration_error";

		// Token: 0x04003BC7 RID: 15303
		[Token(Token = "0x4003BC7")]
		private const string SYNC_ACCOUNT_PROCESS_START = "sync_account_process_start";

		// Token: 0x04003BC8 RID: 15304
		[Token(Token = "0x4003BC8")]
		private const string SYNC_ACCOUNT_PROCESS_COMPLETE = "sync_account_process_complete";

		// Token: 0x04003BC9 RID: 15305
		[Token(Token = "0x4003BC9")]
		[FieldOffset(Offset = "0x10")]
		private readonly LoginCmd.Types.Result[] _skipLoginErrors;
	}
}
