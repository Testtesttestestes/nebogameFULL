using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Application.Managers;
using Core.Gameplay;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Auth2;

namespace Core.Events.Scopes
{
	// Token: 0x02000FCB RID: 4043
	[Token(Token = "0x2000FCB")]
	public class AuthScope : AbstractEventBusScope
	{
		// Token: 0x0600609B RID: 24731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600609B")]
		[Address(RVA = "0xACC7", Offset = "0xACC7", VA = "0xACC7", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600609C RID: 24732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600609C")]
		[Address(RVA = "0xACC8", Offset = "0xACC8", VA = "0xACC8")]
		public AuthScope()
		{
		}

		// Token: 0x0400338A RID: 13194
		[Token(Token = "0x400338A")]
		[FieldOffset(Offset = "0x8")]
		public Action<AuthScope.BaseAuthEventArgs> LoginEvent;

		// Token: 0x0400338B RID: 13195
		[Token(Token = "0x400338B")]
		[FieldOffset(Offset = "0xC")]
		public Action<AuthScope.LoginErrorEventArgs> LoginErrorEvent;

		// Token: 0x0400338C RID: 13196
		[Token(Token = "0x400338C")]
		[FieldOffset(Offset = "0x10")]
		public Action<AuthScope.RegistrationRequestEventArgs> RegistrationRequestEvent;

		// Token: 0x0400338D RID: 13197
		[Token(Token = "0x400338D")]
		[FieldOffset(Offset = "0x14")]
		public Action<AuthScope.BaseAuthEventArgs> RegistrationEvent;

		// Token: 0x0400338E RID: 13198
		[Token(Token = "0x400338E")]
		[FieldOffset(Offset = "0x18")]
		public Action<AuthScope.RegisterErrorEventArgs> RegistrationErrorEvent;

		// Token: 0x0400338F RID: 13199
		[Token(Token = "0x400338F")]
		[FieldOffset(Offset = "0x1C")]
		public Action<AuthScope.BaseAuthEventArgs> UserIdChangedEvent;

		// Token: 0x04003390 RID: 13200
		[Token(Token = "0x4003390")]
		[FieldOffset(Offset = "0x20")]
		public Action<AuthScope.SyncAccountEventArgs> SyncAccountProcessStartEvent;

		// Token: 0x04003391 RID: 13201
		[Token(Token = "0x4003391")]
		[FieldOffset(Offset = "0x24")]
		public Action<AuthScope.SyncAccountEventArgs> SyncAccountProcessCompleteEvent;

		// Token: 0x02000FCC RID: 4044
		[Token(Token = "0x2000FCC")]
		public class LoginErrorEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x0600609D RID: 24733 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600609D")]
			[Address(RVA = "0xACC9", Offset = "0xACC9", VA = "0xACC9")]
			public LoginErrorEventArgs(IApp app, IGame game, LoginCmd.Types.Result errorCode, SigninRecord signinRecord)
			{
			}

			// Token: 0x04003392 RID: 13202
			[Token(Token = "0x4003392")]
			[FieldOffset(Offset = "0x10")]
			public readonly LoginCmd.Types.Result ErrorCode;

			// Token: 0x04003393 RID: 13203
			[Token(Token = "0x4003393")]
			[FieldOffset(Offset = "0x14")]
			public readonly SigninRecord SigninRecord;
		}

		// Token: 0x02000FCD RID: 4045
		[Token(Token = "0x2000FCD")]
		public class RegisterErrorEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001303 RID: 4867
			// (get) Token: 0x0600609E RID: 24734 RVA: 0x00011988 File Offset: 0x0000FB88
			// (set) Token: 0x0600609F RID: 24735 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001303")]
			public RegisterCmd.Types.Result ErrorCode
			{
				[Token(Token = "0x600609E")]
				[Address(RVA = "0xACCA", Offset = "0xACCA", VA = "0xACCA")]
				[CompilerGenerated]
				get
				{
					return RegisterCmd.Types.Result.Ok;
				}
				[Token(Token = "0x600609F")]
				[Address(RVA = "0xACCB", Offset = "0xACCB", VA = "0xACCB")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060060A0 RID: 24736 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060A0")]
			[Address(RVA = "0xACCC", Offset = "0xACCC", VA = "0xACCC")]
			public RegisterErrorEventArgs(IApp app, IGame game, RegisterCmd.Types.Result errorCode, SigninRecord signinRecord)
			{
			}

			// Token: 0x04003395 RID: 13205
			[Token(Token = "0x4003395")]
			[FieldOffset(Offset = "0x14")]
			public readonly SigninRecord SigninRecord;
		}

		// Token: 0x02000FCE RID: 4046
		[Token(Token = "0x2000FCE")]
		public class BaseAuthEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001304 RID: 4868
			// (get) Token: 0x060060A1 RID: 24737 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060060A2 RID: 24738 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001304")]
			public IAuthDataProvider Provider
			{
				[Token(Token = "0x60060A1")]
				[Address(RVA = "0xACCD", Offset = "0xACCD", VA = "0xACCD")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60060A2")]
				[Address(RVA = "0xACCE", Offset = "0xACCE", VA = "0xACCE")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060060A3 RID: 24739 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060A3")]
			[Address(RVA = "0xACCF", Offset = "0xACCF", VA = "0xACCF")]
			public BaseAuthEventArgs(IApp app, IGame game, IAuthDataProvider provider)
			{
			}

			// Token: 0x060060A4 RID: 24740 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60060A4")]
			[Address(RVA = "0xACD0", Offset = "0xACD0", VA = "0xACD0", Slot = "4")]
			public override Dictionary<string, object> GetEventProperties()
			{
				return null;
			}
		}

		// Token: 0x02000FCF RID: 4047
		[Token(Token = "0x2000FCF")]
		public class RegistrationRequestEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001305 RID: 4869
			// (get) Token: 0x060060A5 RID: 24741 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060060A6 RID: 24742 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001305")]
			public string Nick
			{
				[Token(Token = "0x60060A5")]
				[Address(RVA = "0xACD1", Offset = "0xACD1", VA = "0xACD1")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60060A6")]
				[Address(RVA = "0xACD2", Offset = "0xACD2", VA = "0xACD2")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001306 RID: 4870
			// (get) Token: 0x060060A7 RID: 24743 RVA: 0x000119A0 File Offset: 0x0000FBA0
			// (set) Token: 0x060060A8 RID: 24744 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001306")]
			public uint AprId
			{
				[Token(Token = "0x60060A7")]
				[Address(RVA = "0xACD3", Offset = "0xACD3", VA = "0xACD3")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
				[Token(Token = "0x60060A8")]
				[Address(RVA = "0xACD4", Offset = "0xACD4", VA = "0xACD4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060060A9 RID: 24745 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060A9")]
			[Address(RVA = "0xACD5", Offset = "0xACD5", VA = "0xACD5")]
			public RegistrationRequestEventArgs(App app, IGame game, string nick, uint aprId)
			{
			}
		}

		// Token: 0x02000FD0 RID: 4048
		[Token(Token = "0x2000FD0")]
		public class SyncAccountEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x060060AA RID: 24746 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060AA")]
			[Address(RVA = "0xACD6", Offset = "0xACD6", VA = "0xACD6")]
			public SyncAccountEventArgs(SigninRecord signinRecord, App app, IGame game)
			{
			}

			// Token: 0x060060AB RID: 24747 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060AB")]
			[Address(RVA = "0xACD7", Offset = "0xACD7", VA = "0xACD7")]
			public SyncAccountEventArgs(ulong userId, uint userLevel, App app, IGame game)
			{
			}

			// Token: 0x060060AC RID: 24748 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060AC")]
			[Address(RVA = "0xACD8", Offset = "0xACD8", VA = "0xACD8")]
			public SyncAccountEventArgs(ulong userId, App app, IGame game)
			{
			}

			// Token: 0x04003399 RID: 13209
			[Token(Token = "0x4003399")]
			[FieldOffset(Offset = "0x10")]
			public readonly ulong UserId;

			// Token: 0x0400339A RID: 13210
			[Token(Token = "0x400339A")]
			[FieldOffset(Offset = "0x18")]
			public readonly ulong UserLevel;

			// Token: 0x0400339B RID: 13211
			[Token(Token = "0x400339B")]
			[FieldOffset(Offset = "0x20")]
			[CanBeNull]
			public readonly SigninRecord SigninRecord;
		}
	}
}
