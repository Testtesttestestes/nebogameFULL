using System;
using Core.Application.Managers;
using Core.Application.Managers.Connection;
using Core.Application.Managers.Environment;
using Core.Gameplay;
using Core.Gameplay.Managers;
using Core.Gameplay.Managers.Configuration;
using Core.Log.Files;
using Il2CppDummyDll;
using JetBrains.Annotations;
using OKG.Heavens.External.Common;
using Protocol.Consts;
using UI;
using UI.ConfirmationMessage;
using UI.ContextMenu;
using UI.Toast;
using UI.ToolTip.Controller;
using UI.Windows;
using UnityEngine;

namespace Core.Application
{
	// Token: 0x02001235 RID: 4661
	[Token(Token = "0x2001235")]
	public interface IApp
	{
		// Token: 0x140002E1 RID: 737
		// (add) Token: 0x06006E8F RID: 28303
		// (remove) Token: 0x06006E90 RID: 28304
		[Token(Token = "0x140002E1")]
		event Action<IApp> InitCompleteEvent;

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x06006E91 RID: 28305
		[Token(Token = "0x1700167A")]
		ClientPlatform Platform { [Token(Token = "0x6006E91")] get; }

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06006E92 RID: 28306
		[Token(Token = "0x1700167B")]
		AppCanvas AppCanvas { [Token(Token = "0x6006E92")] get; }

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x06006E93 RID: 28307
		[Token(Token = "0x1700167C")]
		ContextMenuController ContextMenuController { [Token(Token = "0x6006E93")] get; }

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x06006E94 RID: 28308
		[Token(Token = "0x1700167D")]
		PopupController PopupController { [Token(Token = "0x6006E94")] get; }

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x06006E95 RID: 28309
		[Token(Token = "0x1700167E")]
		ToastController ToastController { [Token(Token = "0x6006E95")] get; }

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x06006E96 RID: 28310
		[Token(Token = "0x1700167F")]
		ConfirmationMessageController ConfirmationMessageController { [Token(Token = "0x6006E96")] get; }

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x06006E97 RID: 28311
		[Token(Token = "0x17001680")]
		EventBusManager EventBusManager { [Token(Token = "0x6006E97")] get; }

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06006E98 RID: 28312
		[Token(Token = "0x17001681")]
		FilesAppManager FilesManager { [Token(Token = "0x6006E98")] get; }

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06006E99 RID: 28313
		[Token(Token = "0x17001682")]
		ConfigurationManager ConfigurationManager { [Token(Token = "0x6006E99")] get; }

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x06006E9A RID: 28314
		[Token(Token = "0x17001683")]
		AppBuildInfoManager AppBuildInfoManager { [Token(Token = "0x6006E9A")] get; }

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x06006E9B RID: 28315
		[Token(Token = "0x17001684")]
		ConnectionManager ConnectionManager { [Token(Token = "0x6006E9B")] get; }

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x06006E9C RID: 28316
		[Token(Token = "0x17001685")]
		PlatformSigninManager PlatformSigninManager { [Token(Token = "0x6006E9C")] get; }

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x06006E9D RID: 28317
		[Token(Token = "0x17001686")]
		IToolTipController ToolTipController { [Token(Token = "0x6006E9D")] get; }

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x06006E9E RID: 28318
		[Token(Token = "0x17001687")]
		AppLoader AppLoader { [Token(Token = "0x6006E9E")] get; }

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x06006E9F RID: 28319
		[Token(Token = "0x17001688")]
		DeepLinkManager DeepLinkManager { [Token(Token = "0x6006E9F")] get; }

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06006EA0 RID: 28320
		[Token(Token = "0x17001689")]
		INotificationManager NotificationManager { [Token(Token = "0x6006EA0")] get; }

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06006EA1 RID: 28321
		[Token(Token = "0x1700168A")]
		Transform TopLayer { [Token(Token = "0x6006EA1")] get; }

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06006EA2 RID: 28322
		[Token(Token = "0x1700168B")]
		IAppHolder AppAppHolder { [Token(Token = "0x6006EA2")] get; }

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x06006EA3 RID: 28323
		[Token(Token = "0x1700168C")]
		[CanBeNull]
		Auth Auth { [Token(Token = "0x6006EA3")] get; }

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x06006EA4 RID: 28324
		[Token(Token = "0x1700168D")]
		IGameRestart GameRestart { [Token(Token = "0x6006EA4")] get; }

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x06006EA5 RID: 28325
		[Token(Token = "0x1700168E")]
		IGameResolver GameResolver { [Token(Token = "0x6006EA5")] get; }

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x06006EA6 RID: 28326
		[Token(Token = "0x1700168F")]
		TokensManager TokensManager { [Token(Token = "0x6006EA6")] get; }

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x06006EA7 RID: 28327
		[Token(Token = "0x17001690")]
		IEnvironment PlatformEnvironmentManager { [Token(Token = "0x6006EA7")] get; }

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06006EA8 RID: 28328
		[Token(Token = "0x17001691")]
		FileDownloadLogger FileDownloadLogger { [Token(Token = "0x6006EA8")] get; }

		// Token: 0x06006EA9 RID: 28329
		[Token(Token = "0x6006EA9")]
		void SetAuth(Auth value);
	}
}
