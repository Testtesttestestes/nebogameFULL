using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Analytics.Service.Android;
using Core.Application.Managers;
using Core.Application.Managers.Analytics;
using Core.Application.Managers.Connection;
using Core.Application.Managers.Environment;
using Core.Gameplay;
using Core.Gameplay.Managers;
using Core.Gameplay.Managers.Configuration;
using Core.Log.Files;
using Il2CppDummyDll;
using OKG.Heavens.External.Common;
using Protocol.Consts;
using UI;
using UI.ConfirmationMessage;
using UI.ContextMenu;
using UI.Toast;
using UI.ToolTip;
using UI.ToolTip.Controller;
using UI.Windows;
using UnityEngine;

namespace Core.Application
{
	// Token: 0x02001234 RID: 4660
	[Token(Token = "0x2001234")]
	public class App : IApp
	{
		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x06006E55 RID: 28245 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001660")]
		public static App Instance
		{
			[Token(Token = "0x6006E55")]
			[Address(RVA = "0x1AE7", Offset = "0x1AE7", VA = "0x1AE7")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002DF RID: 735
		// (add) Token: 0x06006E56 RID: 28246 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006E57 RID: 28247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002DF")]
		public event Action AppQuitEvent
		{
			[Token(Token = "0x6006E56")]
			[Address(RVA = "0xB8F8", Offset = "0xB8F8", VA = "0xB8F8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006E57")]
			[Address(RVA = "0xB8F9", Offset = "0xB8F9", VA = "0xB8F9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002E0 RID: 736
		// (add) Token: 0x06006E58 RID: 28248 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006E59 RID: 28249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002E0")]
		public event Action<IApp> InitCompleteEvent
		{
			[Token(Token = "0x6006E58")]
			[Address(RVA = "0xB8FA", Offset = "0xB8FA", VA = "0xB8FA", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006E59")]
			[Address(RVA = "0xB8FB", Offset = "0xB8FB", VA = "0xB8FB", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x06006E5A RID: 28250 RVA: 0x00014370 File Offset: 0x00012570
		[Token(Token = "0x17001661")]
		public ClientPlatform Platform
		{
			[Token(Token = "0x6006E5A")]
			[Address(RVA = "0x1AE8", Offset = "0x1AE8", VA = "0x1AE8", Slot = "6")]
			get
			{
				return ClientPlatform.UnknownClientPlatform;
			}
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x06006E5B RID: 28251 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E5C RID: 28252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001662")]
		public AppCanvas AppCanvas
		{
			[Token(Token = "0x6006E5B")]
			[Address(RVA = "0xB8FC", Offset = "0xB8FC", VA = "0xB8FC", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E5C")]
			[Address(RVA = "0xB8FD", Offset = "0xB8FD", VA = "0xB8FD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x06006E5D RID: 28253 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E5E RID: 28254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001663")]
		public AppLoader AppLoader
		{
			[Token(Token = "0x6006E5D")]
			[Address(RVA = "0xB8FE", Offset = "0xB8FE", VA = "0xB8FE", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E5E")]
			[Address(RVA = "0xB8FF", Offset = "0xB8FF", VA = "0xB8FF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x06006E5F RID: 28255 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E60 RID: 28256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001664")]
		public DeepLinkManager DeepLinkManager
		{
			[Token(Token = "0x6006E5F")]
			[Address(RVA = "0xB900", Offset = "0xB900", VA = "0xB900", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E60")]
			[Address(RVA = "0xB901", Offset = "0xB901", VA = "0xB901")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x06006E61 RID: 28257 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001665")]
		public ContextMenuController ContextMenuController
		{
			[Token(Token = "0x6006E61")]
			[Address(RVA = "0xB902", Offset = "0xB902", VA = "0xB902", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x06006E62 RID: 28258 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001666")]
		public PopupController PopupController
		{
			[Token(Token = "0x6006E62")]
			[Address(RVA = "0x4443", Offset = "0x4443", VA = "0x4443", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x06006E63 RID: 28259 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001667")]
		public Transform TopLayer
		{
			[Token(Token = "0x6006E63")]
			[Address(RVA = "0xB903", Offset = "0xB903", VA = "0xB903", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x06006E64 RID: 28260 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001668")]
		public IAppHolder AppAppHolder
		{
			[Token(Token = "0x6006E64")]
			[Address(RVA = "0xB904", Offset = "0xB904", VA = "0xB904", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x06006E65 RID: 28261 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E66 RID: 28262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001669")]
		public Auth Auth
		{
			[Token(Token = "0x6006E65")]
			[Address(RVA = "0xB905", Offset = "0xB905", VA = "0xB905", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E66")]
			[Address(RVA = "0xB906", Offset = "0xB906", VA = "0xB906")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x06006E67 RID: 28263 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700166A")]
		public IGameRestart GameRestart
		{
			[Token(Token = "0x6006E67")]
			[Address(RVA = "0xB907", Offset = "0xB907", VA = "0xB907", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x06006E68 RID: 28264 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700166B")]
		public IGameResolver GameResolver
		{
			[Token(Token = "0x6006E68")]
			[Address(RVA = "0xB908", Offset = "0xB908", VA = "0xB908", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x06006E69 RID: 28265 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700166C")]
		public ToastController ToastController
		{
			[Token(Token = "0x6006E69")]
			[Address(RVA = "0x1B6C", Offset = "0x1B6C", VA = "0x1B6C", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x06006E6A RID: 28266 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700166D")]
		public ConfirmationMessageController ConfirmationMessageController
		{
			[Token(Token = "0x6006E6A")]
			[Address(RVA = "0xB909", Offset = "0xB909", VA = "0xB909", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x06006E6B RID: 28267 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E6C RID: 28268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700166E")]
		public IEnvironment PlatformEnvironmentManager
		{
			[Token(Token = "0x6006E6B")]
			[Address(RVA = "0xB90A", Offset = "0xB90A", VA = "0xB90A", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E6C")]
			[Address(RVA = "0xB90B", Offset = "0xB90B", VA = "0xB90B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x06006E6D RID: 28269 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E6E RID: 28270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700166F")]
		public UnityServicesManager UnityServicesManager
		{
			[Token(Token = "0x6006E6D")]
			[Address(RVA = "0xB90C", Offset = "0xB90C", VA = "0xB90C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E6E")]
			[Address(RVA = "0xB90D", Offset = "0xB90D", VA = "0xB90D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x06006E6F RID: 28271 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E70 RID: 28272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001670")]
		public EventBusManager EventBusManager
		{
			[Token(Token = "0x6006E6F")]
			[Address(RVA = "0xB90E", Offset = "0xB90E", VA = "0xB90E", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E70")]
			[Address(RVA = "0xB90F", Offset = "0xB90F", VA = "0xB90F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x06006E71 RID: 28273 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E72 RID: 28274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001671")]
		public FilesAppManager FilesManager
		{
			[Token(Token = "0x6006E71")]
			[Address(RVA = "0xB910", Offset = "0xB910", VA = "0xB910", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E72")]
			[Address(RVA = "0xB911", Offset = "0xB911", VA = "0xB911")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x06006E73 RID: 28275 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E74 RID: 28276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001672")]
		public ConfigurationManager ConfigurationManager
		{
			[Token(Token = "0x6006E73")]
			[Address(RVA = "0xB912", Offset = "0xB912", VA = "0xB912", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E74")]
			[Address(RVA = "0xB913", Offset = "0xB913", VA = "0xB913")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x06006E75 RID: 28277 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E76 RID: 28278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001673")]
		public AppBuildInfoManager AppBuildInfoManager
		{
			[Token(Token = "0x6006E75")]
			[Address(RVA = "0xB914", Offset = "0xB914", VA = "0xB914", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E76")]
			[Address(RVA = "0xB915", Offset = "0xB915", VA = "0xB915")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x06006E77 RID: 28279 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E78 RID: 28280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001674")]
		public ConnectionManager ConnectionManager
		{
			[Token(Token = "0x6006E77")]
			[Address(RVA = "0xB916", Offset = "0xB916", VA = "0xB916", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E78")]
			[Address(RVA = "0xB917", Offset = "0xB917", VA = "0xB917")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x06006E79 RID: 28281 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E7A RID: 28282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001675")]
		public PlatformSigninManager PlatformSigninManager
		{
			[Token(Token = "0x6006E79")]
			[Address(RVA = "0xB918", Offset = "0xB918", VA = "0xB918", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E7A")]
			[Address(RVA = "0xB919", Offset = "0xB919", VA = "0xB919")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x06006E7B RID: 28283 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001676")]
		public IToolTipController ToolTipController
		{
			[Token(Token = "0x6006E7B")]
			[Address(RVA = "0xB91A", Offset = "0xB91A", VA = "0xB91A", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x06006E7C RID: 28284 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E7D RID: 28285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001677")]
		public INotificationManager NotificationManager
		{
			[Token(Token = "0x6006E7C")]
			[Address(RVA = "0xB91B", Offset = "0xB91B", VA = "0xB91B", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E7D")]
			[Address(RVA = "0xB91C", Offset = "0xB91C", VA = "0xB91C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06006E7E RID: 28286 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E7F RID: 28287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001678")]
		public TokensManager TokensManager
		{
			[Token(Token = "0x6006E7E")]
			[Address(RVA = "0xB91D", Offset = "0xB91D", VA = "0xB91D", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E7F")]
			[Address(RVA = "0xB91E", Offset = "0xB91E", VA = "0xB91E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x06006E80 RID: 28288 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E81 RID: 28289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001679")]
		public FileDownloadLogger FileDownloadLogger
		{
			[Token(Token = "0x6006E80")]
			[Address(RVA = "0xB91F", Offset = "0xB91F", VA = "0xB91F", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E81")]
			[Address(RVA = "0xB920", Offset = "0xB920", VA = "0xB920")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006E82 RID: 28290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E82")]
		[Address(RVA = "0xB921", Offset = "0xB921", VA = "0xB921")]
		private App()
		{
		}

		// Token: 0x06006E83 RID: 28291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E83")]
		[Address(RVA = "0xB922", Offset = "0xB922", VA = "0xB922", Slot = "30")]
		public void SetAuth(Auth value)
		{
		}

		// Token: 0x06006E84 RID: 28292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E84")]
		[Address(RVA = "0xB923", Offset = "0xB923", VA = "0xB923")]
		public void Init(AppLoader appLoader)
		{
		}

		// Token: 0x06006E85 RID: 28293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E85")]
		[Address(RVA = "0xB924", Offset = "0xB924", VA = "0xB924")]
		private void ApplicationOnLogMessageReceived(string condition, string stacktrace, LogType type)
		{
		}

		// Token: 0x06006E86 RID: 28294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E86")]
		[Address(RVA = "0xB925", Offset = "0xB925", VA = "0xB925")]
		private void AppLoaderOnOnApplicationQuitEvent()
		{
		}

		// Token: 0x06006E87 RID: 28295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E87")]
		[Address(RVA = "0xB926", Offset = "0xB926", VA = "0xB926")]
		private void CreateAppManagers()
		{
		}

		// Token: 0x06006E88 RID: 28296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E88")]
		[Address(RVA = "0xB927", Offset = "0xB927", VA = "0xB927")]
		private void HandleManagersQueue()
		{
		}

		// Token: 0x06006E89 RID: 28297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E89")]
		[Address(RVA = "0xB928", Offset = "0xB928", VA = "0xB928")]
		private void ManagerInitComplete(IBaseManager manager)
		{
		}

		// Token: 0x06006E8A RID: 28298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E8A")]
		[Address(RVA = "0xB929", Offset = "0xB929", VA = "0xB929")]
		private void InitCompleted()
		{
		}

		// Token: 0x06006E8B RID: 28299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E8B")]
		[Address(RVA = "0xB92A", Offset = "0xB92A", VA = "0xB92A")]
		private void FPSStatsOnAverageFpsCalculatedEvent(float fps)
		{
		}

		// Token: 0x06006E8C RID: 28300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E8C")]
		[Address(RVA = "0xB92B", Offset = "0xB92B", VA = "0xB92B")]
		private void ToolTipControllerOnShownEvent(IToolTipSource data)
		{
		}

		// Token: 0x06006E8D RID: 28301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E8D")]
		[Address(RVA = "0xB92C", Offset = "0xB92C", VA = "0xB92C")]
		private void PopupControllerOnWindowOpenedEvent(string windowId, BaseWindowArgs windowArgs)
		{
		}

		// Token: 0x06006E8E RID: 28302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E8E")]
		[Address(RVA = "0xB92D", Offset = "0xB92D", VA = "0xB92D")]
		private void PopupControllerOnWindowClosedEvent(string windowId, WindowCloseReason windowCloseReason)
		{
		}

		// Token: 0x040039BF RID: 14783
		[Token(Token = "0x40039BF")]
		[FieldOffset(Offset = "0x0")]
		private static App _instance;

		// Token: 0x040039C2 RID: 14786
		[Token(Token = "0x40039C2")]
		[FieldOffset(Offset = "0x10")]
		private List<IBaseManager> _managers;

		// Token: 0x040039C3 RID: 14787
		[Token(Token = "0x40039C3")]
		[FieldOffset(Offset = "0x14")]
		private int _initManagerIndex;

		// Token: 0x040039CA RID: 14794
		[Token(Token = "0x40039CA")]
		[FieldOffset(Offset = "0x30")]
		private AnalyticsManager _analyticsManager;

		// Token: 0x040039CD RID: 14797
		[Token(Token = "0x40039CD")]
		[FieldOffset(Offset = "0x3C")]
		private AnimationSupportManager _animationSupportManager;

		// Token: 0x040039CE RID: 14798
		[Token(Token = "0x40039CE")]
		[FieldOffset(Offset = "0x40")]
		private DeviceIDProvider _deviceIDProvider;
	}
}
