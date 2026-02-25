using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Application.Managers;
using Core.Data;
using Core.Gameplay;
using Core.Gameplay.Managers;
using Gameplay.AccountLinker.View;
using Gameplay.RegisterV2.Control;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Auth2;
using UI.Tabs;

namespace Gameplay.AccountLinker.Model
{
	// Token: 0x02000E15 RID: 3605
	[Token(Token = "0x2000E15")]
	public class AccountLinkerModel : AbstractModel
	{
		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x060057E3 RID: 22499 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060057E4 RID: 22500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011EE")]
		public LinkerUser CurrentSelectedUser
		{
			[Token(Token = "0x60057E3")]
			[Address(RVA = "0xA556", Offset = "0xA556", VA = "0xA556")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057E4")]
			[Address(RVA = "0xA557", Offset = "0xA557", VA = "0xA557")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x060057E5 RID: 22501 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060057E6 RID: 22502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011EF")]
		public string CurrentCode
		{
			[Token(Token = "0x60057E5")]
			[Address(RVA = "0xA558", Offset = "0xA558", VA = "0xA558")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057E6")]
			[Address(RVA = "0xA559", Offset = "0xA559", VA = "0xA559")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x060057E7 RID: 22503 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060057E8 RID: 22504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011F0")]
		public OTPTokenGenCmd.Types.Ans CurrentOptTokenResult
		{
			[Token(Token = "0x60057E7")]
			[Address(RVA = "0xA55A", Offset = "0xA55A", VA = "0xA55A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057E8")]
			[Address(RVA = "0xA55B", Offset = "0xA55B", VA = "0xA55B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x060057E9 RID: 22505 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060057EA RID: 22506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011F1")]
		[CanBeNull]
		public IRegistration RegisterController
		{
			[Token(Token = "0x60057E9")]
			[Address(RVA = "0xA55C", Offset = "0xA55C", VA = "0xA55C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057EA")]
			[Address(RVA = "0xA55D", Offset = "0xA55D", VA = "0xA55D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060057EB RID: 22507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057EB")]
		[Address(RVA = "0xA55E", Offset = "0xA55E", VA = "0xA55E", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060057EC RID: 22508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057EC")]
		[Address(RVA = "0xA55F", Offset = "0xA55F", VA = "0xA55F")]
		public AccountLinkerModel(PlatformSigninManager platformSigninManager, ILoginProvider loginProvider, IRegistrationProvider registrationProvider, ILoggedUserIdSetter loggedUserIdSetter, IGameRestart gameRestart, UserData user)
		{
		}

		// Token: 0x060057ED RID: 22509 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60057ED")]
		[Address(RVA = "0xA560", Offset = "0xA560", VA = "0xA560")]
		public List<TabBarItemData> GetTabs()
		{
			return null;
		}

		// Token: 0x060057EE RID: 22510 RVA: 0x0000FA50 File Offset: 0x0000DC50
		[Token(Token = "0x60057EE")]
		[Address(RVA = "0xA561", Offset = "0xA561", VA = "0xA561")]
		public SignInVariants.States GetCurrentSigninState()
		{
			return SignInVariants.States.UNKNOWN;
		}

		// Token: 0x060057EF RID: 22511 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60057EF")]
		[Address(RVA = "0x488D", Offset = "0x488D", VA = "0x488D")]
		public SigninRecord GetSigninRecord()
		{
			return null;
		}

		// Token: 0x04002F97 RID: 12183
		[Token(Token = "0x4002F97")]
		public const string GET_CODE_TAB_LOCALE_KEY = "ACCOUNT_LINKER/GET_CODE_TAB_TITLE";

		// Token: 0x04002F98 RID: 12184
		[Token(Token = "0x4002F98")]
		public const string SET_CODE_TAB_LOCALE_KEY = "ACCOUNT_LINKER/SET_CODE_TAB_TITLE";

		// Token: 0x04002F99 RID: 12185
		[Token(Token = "0x4002F99")]
		public const string SAVE_PROGRESS_TAB_LOCALE_KEY = "ACCOUNT_LINKER/SAVE_PROGRESS_TAB_TITLE";

		// Token: 0x04002F9A RID: 12186
		[Token(Token = "0x4002F9A")]
		[FieldOffset(Offset = "0xC")]
		public TabBarItemData GetCodeTab;

		// Token: 0x04002F9B RID: 12187
		[Token(Token = "0x4002F9B")]
		[FieldOffset(Offset = "0x10")]
		public TabBarItemData SetCodeTab;

		// Token: 0x04002F9C RID: 12188
		[Token(Token = "0x4002F9C")]
		[FieldOffset(Offset = "0x14")]
		public TabBarItemData SigninTab;

		// Token: 0x04002F9D RID: 12189
		[Token(Token = "0x4002F9D")]
		[FieldOffset(Offset = "0x18")]
		public List<LinkerUser> CurrentAdditionalUsers;

		// Token: 0x04002FA2 RID: 12194
		[Token(Token = "0x4002FA2")]
		[FieldOffset(Offset = "0x2C")]
		public readonly ILoginProvider LoginProvider;

		// Token: 0x04002FA3 RID: 12195
		[Token(Token = "0x4002FA3")]
		[FieldOffset(Offset = "0x30")]
		public readonly IRegistrationProvider RegistrationProvider;

		// Token: 0x04002FA4 RID: 12196
		[Token(Token = "0x4002FA4")]
		[FieldOffset(Offset = "0x34")]
		public readonly ILoggedUserIdSetter LoggedUserIdSetter;

		// Token: 0x04002FA5 RID: 12197
		[Token(Token = "0x4002FA5")]
		[FieldOffset(Offset = "0x38")]
		public readonly IGameRestart GameRestart;

		// Token: 0x04002FA6 RID: 12198
		[Token(Token = "0x4002FA6")]
		[FieldOffset(Offset = "0x3C")]
		public readonly PlatformSigninManager PlatformSigninManager;

		// Token: 0x04002FA7 RID: 12199
		[Token(Token = "0x4002FA7")]
		[FieldOffset(Offset = "0x40")]
		public bool SignToTargetProviderInProgress;
	}
}
