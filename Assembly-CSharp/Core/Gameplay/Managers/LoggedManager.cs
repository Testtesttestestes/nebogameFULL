using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Application.Managers;
using Core.Application.Managers.Connection;
using Core.Gameplay.Managers.Configuration;
using Google.Protobuf;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Auth2;
using Protocol.Consts;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001134 RID: 4404
	[Token(Token = "0x2001134")]
	public class LoggedManager : IAuthDataProvider, ILoginProvider, IRegistrationProvider, ILoggedUserIdSetter, IBaseManager
	{
		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x06006724 RID: 26404 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001524")]
		public string Name
		{
			[Token(Token = "0x6006724")]
			[Address(RVA = "0xB255", Offset = "0xB255", VA = "0xB255", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400024D RID: 589
		// (add) Token: 0x06006725 RID: 26405 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006726 RID: 26406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400024D")]
		public event Action<IAuthDataProvider> LoginSuccessEvent
		{
			[Token(Token = "0x6006725")]
			[Address(RVA = "0xB256", Offset = "0xB256", VA = "0xB256")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006726")]
			[Address(RVA = "0xB257", Offset = "0xB257", VA = "0xB257")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400024E RID: 590
		// (add) Token: 0x06006727 RID: 26407 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006728 RID: 26408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400024E")]
		public event Action<IAuthDataProvider> RegisterSuccessEvent
		{
			[Token(Token = "0x6006727")]
			[Address(RVA = "0xB258", Offset = "0xB258", VA = "0xB258")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006728")]
			[Address(RVA = "0xB259", Offset = "0xB259", VA = "0xB259")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400024F RID: 591
		// (add) Token: 0x06006729 RID: 26409 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600672A RID: 26410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400024F")]
		public event Action<LoginCmd.Types.Result, SigninRecord> LoginErrorEvent
		{
			[Token(Token = "0x6006729")]
			[Address(RVA = "0xB25A", Offset = "0xB25A", VA = "0xB25A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600672A")]
			[Address(RVA = "0xB25B", Offset = "0xB25B", VA = "0xB25B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000250 RID: 592
		// (add) Token: 0x0600672B RID: 26411 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600672C RID: 26412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000250")]
		public event Action<RegisterCmd.Types.Result, SigninRecord> RegisterErrorEvent
		{
			[Token(Token = "0x600672B")]
			[Address(RVA = "0xB25C", Offset = "0xB25C", VA = "0xB25C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600672C")]
			[Address(RVA = "0xB25D", Offset = "0xB25D", VA = "0xB25D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000251 RID: 593
		// (add) Token: 0x0600672D RID: 26413 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600672E RID: 26414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000251")]
		public event Action<ulong> UserIdChangedEvent
		{
			[Token(Token = "0x600672D")]
			[Address(RVA = "0xB25E", Offset = "0xB25E", VA = "0xB25E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600672E")]
			[Address(RVA = "0xB25F", Offset = "0xB25F", VA = "0xB25F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000252 RID: 594
		// (add) Token: 0x0600672F RID: 26415 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006730 RID: 26416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000252")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600672F")]
			[Address(RVA = "0xB260", Offset = "0xB260", VA = "0xB260", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006730")]
			[Address(RVA = "0xB261", Offset = "0xB261", VA = "0xB261", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000253 RID: 595
		// (add) Token: 0x06006731 RID: 26417 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006732 RID: 26418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000253")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006731")]
			[Address(RVA = "0xB262", Offset = "0xB262", VA = "0xB262", Slot = "11")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006732")]
			[Address(RVA = "0xB263", Offset = "0xB263", VA = "0xB263", Slot = "12")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x06006733 RID: 26419 RVA: 0x000137D0 File Offset: 0x000119D0
		// (set) Token: 0x06006734 RID: 26420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001525")]
		public int SuccessLoginCount
		{
			[Token(Token = "0x6006733")]
			[Address(RVA = "0xB264", Offset = "0xB264", VA = "0xB264", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006734")]
			[Address(RVA = "0xB265", Offset = "0xB265", VA = "0xB265")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x06006735 RID: 26421 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006736 RID: 26422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001526")]
		public IPlatformConfigurationProvider ConfigurationProvider
		{
			[Token(Token = "0x6006735")]
			[Address(RVA = "0xB266", Offset = "0xB266", VA = "0xB266")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006736")]
			[Address(RVA = "0xB267", Offset = "0xB267", VA = "0xB267")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x06006737 RID: 26423 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006738 RID: 26424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001527")]
		public AuthData AuthData
		{
			[Token(Token = "0x6006737")]
			[Address(RVA = "0xB268", Offset = "0xB268", VA = "0xB268", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006738")]
			[Address(RVA = "0xB269", Offset = "0xB269", VA = "0xB269")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006739 RID: 26425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006739")]
		[Address(RVA = "0xB26A", Offset = "0xB26A", VA = "0xB26A")]
		public LoggedManager(IApp app, IGameRestart gameRestart, IGameResolver gameResolver, IPlatformConfigurationProvider configurationProvider, IRecoveryConnection recoveryConnection)
		{
		}

		// Token: 0x0600673A RID: 26426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673A")]
		[Address(RVA = "0xB26B", Offset = "0xB26B", VA = "0xB26B", Slot = "14")]
		public void Deinit()
		{
		}

		// Token: 0x0600673B RID: 26427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673B")]
		[Address(RVA = "0xB26C", Offset = "0xB26C", VA = "0xB26C", Slot = "13")]
		public void Init()
		{
		}

		// Token: 0x0600673C RID: 26428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673C")]
		[Address(RVA = "0xB26D", Offset = "0xB26D", VA = "0xB26D")]
		private void OnDictionariesUpdatedEvent(ProtoDictionariesUpdatedEvt evt)
		{
		}

		// Token: 0x0600673D RID: 26429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673D")]
		[Address(RVA = "0xB26E", Offset = "0xB26E", VA = "0xB26E")]
		private void HandleMoveUserEvent(MoveUserEvt evt)
		{
		}

		// Token: 0x0600673E RID: 26430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673E")]
		[Address(RVA = "0xB26F", Offset = "0xB26F", VA = "0xB26F")]
		private void HandleLoginService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600673F RID: 26431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673F")]
		[Address(RVA = "0x2288", Offset = "0x2288", VA = "0x2288")]
		private void HandleSigninFailed()
		{
		}

		// Token: 0x06006740 RID: 26432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006740")]
		[Address(RVA = "0xB270", Offset = "0xB270", VA = "0xB270")]
		private void HandleLoginFailed(LoginCmd.Types.Result loginResult, bool isCanDoContinueAuthPipeline)
		{
		}

		// Token: 0x06006741 RID: 26433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006741")]
		[Address(RVA = "0xB271", Offset = "0xB271", VA = "0xB271")]
		private void OnRegisterService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06006742 RID: 26434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006742")]
		[Address(RVA = "0xB272", Offset = "0xB272", VA = "0xB272")]
		public void SetupAuthData([NotNull] AuthData data)
		{
		}

		// Token: 0x06006743 RID: 26435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006743")]
		[Address(RVA = "0xB273", Offset = "0xB273", VA = "0xB273", Slot = "8")]
		public void RequestSetUserId(ulong userId, Action<OpToken<IMessage, object>> callback)
		{
		}

		// Token: 0x06006744 RID: 26436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006744")]
		[Address(RVA = "0xB274", Offset = "0xB274", VA = "0xB274", Slot = "7")]
		public void Register(string nick, uint aprId, Action<LoggedManager.RegisterCallbackInvoker, RegisterCmd.Types.Ans> resultCallback)
		{
		}

		// Token: 0x06006745 RID: 26437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006745")]
		[Address(RVA = "0x2283", Offset = "0x2283", VA = "0x2283", Slot = "6")]
		public void RequestLogin(ClientPlatform clientPlatform, SigninRecord record, Action<LoggedManager.LoginCallbackInvoker, LoginCmd.Types.Ans> callback)
		{
		}

		// Token: 0x0400370E RID: 14094
		[Token(Token = "0x400370E")]
		[FieldOffset(Offset = "0x24")]
		private Auth2Service _authService;

		// Token: 0x04003712 RID: 14098
		[Token(Token = "0x4003712")]
		[FieldOffset(Offset = "0x34")]
		public readonly IApp _app;

		// Token: 0x04003713 RID: 14099
		[Token(Token = "0x4003713")]
		[FieldOffset(Offset = "0x38")]
		private readonly IGameRestart _gameRestart;

		// Token: 0x04003714 RID: 14100
		[Token(Token = "0x4003714")]
		[FieldOffset(Offset = "0x3C")]
		private readonly IGameResolver _gameResolver;

		// Token: 0x02001135 RID: 4405
		[Token(Token = "0x2001135")]
		public class LoginCallbackInvoker
		{
			// Token: 0x06006748 RID: 26440 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006748")]
			[Address(RVA = "0xB277", Offset = "0xB277", VA = "0xB277")]
			public LoginCallbackInvoker(SigninRecord record, Action<LoggedManager.LoginCallbackInvoker, LoginCmd.Types.Ans> callback)
			{
			}

			// Token: 0x06006749 RID: 26441 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006749")]
			[Address(RVA = "0xB278", Offset = "0xB278", VA = "0xB278")]
			public void Invoke(LoginCmd.Types.Ans value)
			{
			}

			// Token: 0x04003715 RID: 14101
			[Token(Token = "0x4003715")]
			[FieldOffset(Offset = "0x8")]
			[NotNull]
			public readonly SigninRecord Record;

			// Token: 0x04003716 RID: 14102
			[Token(Token = "0x4003716")]
			[FieldOffset(Offset = "0xC")]
			[CanBeNull]
			private Action<LoggedManager.LoginCallbackInvoker, LoginCmd.Types.Ans> _callback;
		}

		// Token: 0x02001136 RID: 4406
		[Token(Token = "0x2001136")]
		public class RegisterCallbackInvoker
		{
			// Token: 0x0600674A RID: 26442 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600674A")]
			[Address(RVA = "0xB279", Offset = "0xB279", VA = "0xB279")]
			public RegisterCallbackInvoker([NotNull] string nick, uint aprId, [NotNull] SigninRecord record, [NotNull] Action<LoggedManager.RegisterCallbackInvoker, RegisterCmd.Types.Ans> callback)
			{
			}

			// Token: 0x0600674B RID: 26443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600674B")]
			[Address(RVA = "0xB27A", Offset = "0xB27A", VA = "0xB27A")]
			public void Invoke(RegisterCmd.Types.Ans value)
			{
			}

			// Token: 0x04003717 RID: 14103
			[Token(Token = "0x4003717")]
			[FieldOffset(Offset = "0x8")]
			[NotNull]
			public readonly SigninRecord Record;

			// Token: 0x04003718 RID: 14104
			[Token(Token = "0x4003718")]
			[FieldOffset(Offset = "0xC")]
			[NotNull]
			public readonly string Nick;

			// Token: 0x04003719 RID: 14105
			[Token(Token = "0x4003719")]
			[FieldOffset(Offset = "0x10")]
			public readonly uint AprId;

			// Token: 0x0400371A RID: 14106
			[Token(Token = "0x400371A")]
			[FieldOffset(Offset = "0x14")]
			[NotNull]
			private Action<LoggedManager.RegisterCallbackInvoker, RegisterCmd.Types.Ans> _callback;
		}
	}
}
