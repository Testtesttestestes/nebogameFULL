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
		/* --- GHIDRA: SetAuth ---
		void Core_Application_App__SetAuth(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a7f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Update_AppUpdateInstall_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Application_App_AppLoaderOnOnApplicationQuitEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Application_App_ApplicationOnLogMessageReceived__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_LogCallback_TypeInfo);
		    DAT_ram_00a5a7f5 = '\x01';
		  }
		  unnamed_function_1417(Core_Application_Update_AppUpdateInstall_TypeInfo);
		  uVar1 = unnamed_function_1417(UnityEngine_Application_LogCallback_TypeInfo);
		  UnityEngine_Application_MemoryUsageChangedCallback__Invoke
		            (uVar1,param1,Method_Core_Application_App_ApplicationOnLogMessageReceived__,0);
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  UnityEngine_Application__HasLogCallback(uVar1,0);
		  *(int *)(param1 + 0x1c) = param2;
		  *(undefined4 *)(param1 + 0x18) = *(undefined4 *)(param2 + 0x10);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Core_Application_App_AppLoaderOnOnApplicationQuitEvent__,0);
		  Core_AppLoader__get_AppCanvas(param2,uVar1,0);
		  *(undefined4 *)(param1 + 0x14) = 0;
		  Core_Application_App__AppLoaderOnOnApplicationQuitEvent(param1,param1);
		  Core_Application_App__CreateAppManagers(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06006E84 RID: 28292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E84")]
		[Address(RVA = "0xB923", Offset = "0xB923", VA = "0xB923")]
		public void Init(AppLoader appLoader)
		{
		/* --- GHIDRA: Init ---
		void Core_Application_App__Init
		               (int param1,undefined4 param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param2_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a7f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AppScope_UnhandledExceptionEventArgs_TypeInfo);
		    DAT_ram_00a5a7f6 = '\x01';
		  }
		  if (((param4 == 4) && (*(int *)(param1 + 0x38) != 0)) &&
		     (*(int *)(*(int *)(param1 + 0x38) + 0x10) != 0)) {
		    if (DAT_ram_00a5a7ed == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		      DAT_ram_00a5a7ed = '\x01';
		    }
		    iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    if (iVar2 == 0) {
		      uVar1 = unnamed_function_1417(Core_Application_App_TypeInfo);
		      Core_Application_App__set_FileDownloadLogger(uVar1,uVar1);
		      **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar1;
		      iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    }
		    iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x1c) + 0x18);
		    if (iVar2 != 0) {
		      if (DAT_ram_00a5a7ed == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		        DAT_ram_00a5a7ed = '\x01';
		      }
		      param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		      if (param2_00 == 0) {
		        uVar1 = unnamed_function_1417(Core_Application_App_TypeInfo);
		        Core_Application_App__set_FileDownloadLogger(uVar1,uVar1);
		        **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar1;
		        param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		      }
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      uVar1 = unnamed_function_1417
		                        (Core_Events_Scopes_AppScope_UnhandledExceptionEventArgs_TypeInfo);
		      Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                (uVar1,param2_00,param3_00,param2,param3,0);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),uVar1,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

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
		/* --- GHIDRA: AppLoaderOnOnApplicationQuitEvent ---
		void Core_Application_App__AppLoaderOnOnApplicationQuitEvent(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  uint uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a7f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_Analytics_AnalyticsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_AnimationSupportManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_AppBuildInfoManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_ConfigurationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_Connection_ConnectionManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_DeepLinkManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_EventBusManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_FilesAppManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IBaseManager__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IBaseManager___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_NotificationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Environment_PlatformEnvironmentManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_PlatformSigninManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_TokensManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_UnityServicesManager_TypeInfo);
		    DAT_ram_00a5a7f7 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_IBaseManager__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_IBaseManager___ctor__);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417(Core_Application_Managers_EventBusManager_TypeInfo);
		  *(undefined4 *)(param1 + 0x38) = uVar1;
		  iVar2 = Method_System_Collections_Generic_List_IBaseManager__Add__;
		  iVar3 = *(int *)(param1 + 0x10);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Application_Managers_UnityServicesManager_TypeInfo);
		  *(undefined4 *)(param1 + 0x34) = uVar1;
		  iVar2 = Method_System_Collections_Generic_List_IBaseManager__Add__;
		  iVar3 = *(int *)(param1 + 0x10);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Application_Managers_AppBuildInfoManager_TypeInfo);
		  *(undefined4 *)(param1 + 0x4c) = uVar1;
		  iVar2 = Method_System_Collections_Generic_List_IBaseManager__Add__;
		  iVar3 = *(int *)(param1 + 0x10);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = unnamed_function_1417(Core_Application_Managers_DeepLinkManager_TypeInfo);
		  *(int *)(iVar3 + 0x14) = param1;
		  *(int *)(param1 + 0x20) = iVar3;
		  iVar2 = Method_System_Collections_Generic_List_IBaseManager__Add__;
		  iVar5 = *(int *)(param1 + 0x10);
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar5 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar5 + 8) + uVar4 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = unnamed_function_1417(Core_Gameplay_Managers_Configuration_ConfigurationManager_TypeInfo);
		  *(int *)(iVar3 + 0x14) = param1;
		  *(int *)(param1 + 0x48) = iVar3;
		  iVar2 = Method_System_Collections_Generic_List_IBaseManager__Add__;
		  iVar5 = *(int *)(param1 + 0x10);
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar5 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar5 + 8) + uVar4 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Core_Application_Managers_Analytics_AnalyticsManager_TypeInfo);
		  if (DAT_ram_00a5a894 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Type__AbstractAnalyticsListener___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Type__AbstractAnalyticsListener__TypeInfo);
		    DAT_ram_00a5a894 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_Type__AbstractAnalyticsListener__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_Type__AbstractAnalyticsListener___ctor__);
		  *(undefined4 *)(iVar2 + 0x14) = uVar1;
		  *(int *)(param1 + 0x30) = iVar2;
		  iVar3 = Method_System_Collections_Generic_List_IBaseManager__Add__;
		  iVar5 = *(int *)(param1 + 0x10);
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar5 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar5 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = unnamed_function_1417(Core_Application_Managers_PlatformSigninManager_TypeInfo);
		  *(int *)(iVar3 + 8) = param1;
		  *(int *)(param1 + 0x54) = iVar3;
		  iVar2 = Method_System_Collections_Generic_List_IBaseManager__Add__;
		  iVar5 = *(int *)(param1 + 0x10);
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar5 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar5 + 8) + uVar4 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417
		                    (Core_Application_Managers_Environment_PlatformEnvironmentManager_TypeInfo);
		  Core_Application_Managers_Environment_PlatformEnvironmentManager__remove_DeinitCompleteEvent
		            (uVar1,param1,param1);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  iVar2 = Method_System_Collections_Generic_List_IBaseManager__Add__;
		  iVar3 = *(int *)(param1 + 0x10);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Application_Managers_AnimationSupportManager_TypeInfo);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  iVar2 = Method_System_Collections_Generic_List_IBaseManager__Add__;
		  iVar3 = *(int *)(param1 + 0x10);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = unnamed_function_1417(Core_Application_Managers_FilesAppManager_TypeInfo);
		  *(int *)(iVar3 + 0x14) = param1;
		  *(int *)(param1 + 0x44) = iVar3;
		  iVar2 = Method_System_Collections_Generic_List_IBaseManager__Add__;
		  iVar5 = *(int *)(param1 + 0x10);
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar5 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar5 + 8) + uVar4 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Application_Managers_Connection_ConnectionManager_TypeInfo);
		  Core_Application_Managers_Connection_ConnectionManager__set_LatencyMonitor(uVar1,param1,param1);
		  *(undefined4 *)(param1 + 0x50) = uVar1;
		  iVar2 = Method_System_Collections_Generic_List_IBaseManager__Add__;
		  iVar3 = *(int *)(param1 + 0x10);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Application_Managers_NotificationManager_TypeInfo);
		  Core_Application_Managers_NotificationManager__remove_DeinitCompleteEvent(uVar1,param1);
		  *(undefined4 *)(param1 + 0x58) = uVar1;
		  iVar2 = Method_System_Collections_Generic_List_IBaseManager__Add__;
		  iVar3 = *(int *)(param1 + 0x10);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_TokensManager_TypeInfo);
		  UnityEngine_Purchasing_Default_WinProductDescription__set_title(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0x5c) = uVar1;
		  iVar2 = Method_System_Collections_Generic_List_IBaseManager__Add__;
		  iVar3 = *(int *)(param1 + 0x10);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar1;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (iVar3,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x06006E87 RID: 28295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E87")]
		[Address(RVA = "0xB926", Offset = "0xB926", VA = "0xB926")]
		private void CreateAppManagers()
		{
		/* --- GHIDRA: CreateAppManagers ---
		void Core_Application_App__CreateAppManagers(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param3;
		  undefined4 param4;
		  int iVar4;
		  undefined4 local_8;
		  int local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5a7f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Application_App_ManagerInitComplete__);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IBaseManager__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IBaseManager__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3163);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10692);
		    DAT_ram_00a5a7f8 = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 0x10) + 0xc) + -1 < *(int *)(param1 + 0x14)) {
		    Core_Application_App__ManagerInitComplete(param1,0);
		  }
		  else {
		    param1_00 = (int *)System_Linq_Enumerable__ToList_object_
		                                 (*(int *)(param1 + 0x10),*(int *)(param1 + 0x14),
		                                  Method_System_Collections_Generic_List_IBaseManager__get_Item__);
		    uVar2 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Core_Application_App_ManagerInitComplete__,0);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x812780e7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,0);
		code_r0x812780e7:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2,puVar3[1]);
		    uVar1 = 0;
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		          goto code_r0x81278163;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,6);
		code_r0x81278163:
		    uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    local_4 = *(int *)(param1 + 0x14) + 1;
		    param3 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    local_8 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xc);
		    param4 = func_ii_1081(DAT_ram_00a66954,&local_8);
		    uVar2 = func_ii_8529(StringLiteral_10692,uVar2,param3,param4,0);
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_3163,uVar2,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		          goto code_r0x81278266;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,4);
		code_r0x81278266:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006E88 RID: 28296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E88")]
		[Address(RVA = "0xB927", Offset = "0xB927", VA = "0xB927")]
		private void HandleManagersQueue()
		{
		/* --- GHIDRA: HandleManagersQueue ---
		void Core_Application_App__HandleManagersQueue(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int param2_00;
		  undefined4 param5;
		  undefined4 param6;
		  int iVar6;
		  int iVar7;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a7f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Application_App_ManagerInitComplete__);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IBaseManager__get_Count__);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AppScope_LoadingEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3165);
		    DAT_ram_00a5a7f9 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Application_App_ManagerInitComplete__,0);
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 200);
		        goto code_r0x81278e59;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_IBaseManager_TypeInfo,1);
		code_r0x81278e59:
		  (**(code **)((ulonglong)*puVar3 * 4))(param2,uVar2,puVar3[1]);
		  if (DAT_ram_00a5a7ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		    DAT_ram_00a5a7ed = '\x01';
		  }
		  iVar7 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  if (iVar7 == 0) {
		    uVar2 = unnamed_function_1417(Core_Application_App_TypeInfo);
		    Core_Application_App__set_FileDownloadLogger(uVar2,uVar2);
		    **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar2;
		    iVar7 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  }
		  iVar7 = *(int *)(*(int *)(*(int *)(*(int *)(iVar7 + 0x38) + 0x10) + 0x1c) + 0x24);
		  if (iVar7 != 0) {
		    if (DAT_ram_00a5a7ed == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		      DAT_ram_00a5a7ed = '\x01';
		    }
		    param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    if (param2_00 == 0) {
		      uVar2 = unnamed_function_1417(Core_Application_App_TypeInfo);
		      Core_Application_App__set_FileDownloadLogger(uVar2,uVar2);
		      **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar2;
		      param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar2 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *param2;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xf0);
		          goto code_r0x81278fd9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,Core_IBaseManager_TypeInfo,6);
		code_r0x81278fd9:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		    param5 = *(undefined4 *)(param1 + 0x14);
		    param6 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xc);
		    uVar5 = unnamed_function_1417(Core_Events_Scopes_AppScope_LoadingEventArgs_TypeInfo);
		    Core_Events_Scopes_TournamentsScope_AddBetEventArgs__get_Bet
		              (uVar5,param2_00,uVar2,uVar4,param5,param6,0);
		    (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		              (*(undefined4 *)(iVar7 + 0x20),uVar5,*(undefined4 *)(iVar7 + 0x14));
		  }
		  iVar7 = *(int *)(param1 + 0x14) + 1;
		  *(int *)(param1 + 0x14) = iVar7;
		  uVar1 = 0;
		  Preloading_Preloader__Show
		            (*(undefined4 *)(*(int *)(param1 + 0x1c) + 0x1c),
		             (float)iVar7 / (float)*(int *)(*(int *)(param1 + 0x10) + 0xc),1,0);
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xf0);
		        goto code_r0x812790c6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_IBaseManager_TypeInfo,6);
		code_r0x812790c6:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  local_4 = *(undefined4 *)(param1 + 0x14);
		  uVar4 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  local_8 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xc);
		  uVar5 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  uVar2 = func_ii_8529(StringLiteral_3165,uVar2,uVar4,uVar5,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  Core_Application_App__CreateAppManagers(param1,uVar2);
		  return;
		}
		*/

		}

		// Token: 0x06006E89 RID: 28297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E89")]
		[Address(RVA = "0xB928", Offset = "0xB928", VA = "0xB928")]
		private void ManagerInitComplete(IBaseManager manager)
		{
		/* --- GHIDRA: ManagerInitComplete ---
		void Core_Application_App__ManagerInitComplete(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  int param2_00;
		  undefined4 uVar5;
		  int *param1_00;
		  
		  if (DAT_ram_00a5a7fa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IToolTipSource__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_string__BaseWindowArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_string__WindowCloseReason__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Application_App_FPSStatsOnAverageFpsCalculatedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Core_Application_App_PopupControllerOnWindowClosedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Application_App_PopupControllerOnWindowOpenedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Application_App_ToolTipControllerOnShownEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Events_BaseEventBusEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_Controller_IToolTipController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11745);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3164);
		    DAT_ram_00a5a7fa = '\x01';
		  }
		  uVar2 = Core_Analytics_Service_Android_CombatCollector___c___ToString_b__17_0
		                    (*(undefined4 *)(param1 + 0x40),0,0);
		  uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11745,uVar2,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_3164,0);
		  if (DAT_ram_00a5a7ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		    DAT_ram_00a5a7ed = '\x01';
		  }
		  iVar4 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  if (iVar4 == 0) {
		    uVar2 = unnamed_function_1417(Core_Application_App_TypeInfo);
		    Core_Application_App__set_FileDownloadLogger(uVar2,uVar2);
		    **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar2;
		    iVar4 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  }
		  iVar4 = *(int *)(*(int *)(*(int *)(*(int *)(iVar4 + 0x38) + 0x10) + 0x1c) + 0xc);
		  if (iVar4 != 0) {
		    if (DAT_ram_00a5a7ed == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		      DAT_ram_00a5a7ed = '\x01';
		    }
		    param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    if (param2_00 == 0) {
		      uVar2 = unnamed_function_1417(Core_Application_App_TypeInfo);
		      Core_Application_App__set_FileDownloadLogger(uVar2,uVar2);
		      **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar2;
		      param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar5 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    uVar2 = unnamed_function_1417(Core_Events_BaseEventBusEventArgs_TypeInfo);
		    Core_Application_Managers_Connection_ServerConnectionDelay__ResetAll(uVar2,param2_00,uVar5,0);
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),uVar2,*(undefined4 *)(iVar4 + 0x14));
		  }
		  if (DAT_ram_00a5a7ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		    DAT_ram_00a5a7ed = '\x01';
		  }
		  iVar4 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  if (iVar4 == 0) {
		    uVar2 = unnamed_function_1417(Core_Application_App_TypeInfo);
		    Core_Application_App__set_FileDownloadLogger(uVar2,uVar2);
		    **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar2;
		    iVar4 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  }
		  uVar5 = *(undefined4 *)(*(int *)(iVar4 + 0x18) + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_string__BaseWindowArgs__TypeInfo);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		            (uVar2,param1,Method_Core_Application_App_PopupControllerOnWindowOpenedEvent__,0);
		  UI_Windows_PopupController__remove_OnChangeStateEvent(uVar5,uVar2,0);
		  if (DAT_ram_00a5a7ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		    DAT_ram_00a5a7ed = '\x01';
		  }
		  iVar4 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  if (iVar4 == 0) {
		    uVar2 = unnamed_function_1417(Core_Application_App_TypeInfo);
		    Core_Application_App__set_FileDownloadLogger(uVar2,uVar2);
		    **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar2;
		    iVar4 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  }
		  uVar5 = *(undefined4 *)(*(int *)(iVar4 + 0x18) + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_string__WindowCloseReason__TypeInfo);
		  System_Action_object__int___Invoke
		            (uVar2,param1,Method_Core_Application_App_PopupControllerOnWindowClosedEvent__,0);
		  UI_Windows_PopupController__remove_OnWindowOpenedEvent(uVar5,uVar2,0);
		  if (DAT_ram_00a5a7ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		    DAT_ram_00a5a7ed = '\x01';
		  }
		  iVar4 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  if (iVar4 == 0) {
		    uVar2 = unnamed_function_1417(Core_Application_App_TypeInfo);
		    Core_Application_App__set_FileDownloadLogger(uVar2,uVar2);
		    **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar2;
		    iVar4 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  }
		  param1_00 = *(int **)(*(int *)(iVar4 + 0x18) + 0x40);
		  uVar1 = 0;
		  uVar2 = unnamed_function_1417(System_Action_IToolTipSource__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Application_App_ToolTipControllerOnShownEvent__,0);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (UI_ToolTip_Controller_IToolTipController_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81278b56;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,UI_ToolTip_Controller_IToolTipController_TypeInfo,0);
		code_r0x81278b56:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2,puVar3[1]);
		  uVar5 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_float__TypeInfo);
		  System_Action_SerializedCommand___Invoke
		            (uVar2,param1,Method_Core_Application_App_FPSStatsOnAverageFpsCalculatedEvent__,0);
		  Utils_Fps_FpsCounter___ctor(uVar5,uVar2,0);
		  iVar4 = *(int *)(param1 + 0xc);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006E8A RID: 28298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E8A")]
		[Address(RVA = "0xB929", Offset = "0xB929", VA = "0xB929")]
		private void InitCompleted()
		{
		/* --- GHIDRA: InitCompleted ---
		void Core_Application_App__InitCompleted(undefined4 param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param2_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a7fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Events_Scopes_AppScope_AverageFpsCalculatedEventArgs_TypeInfo);
		    DAT_ram_00a5a7fb = '\x01';
		  }
		  if (DAT_ram_00a5a7ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		    DAT_ram_00a5a7ed = '\x01';
		  }
		  iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  if (iVar2 == 0) {
		    uVar1 = unnamed_function_1417(Core_Application_App_TypeInfo);
		    Core_Application_App__set_FileDownloadLogger(uVar1,uVar1);
		    **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar1;
		    iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  }
		  iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x1c) + 0x1c);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a5a7ed == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		      DAT_ram_00a5a7ed = '\x01';
		    }
		    param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    if (param2_00 == 0) {
		      uVar1 = unnamed_function_1417(Core_Application_App_TypeInfo);
		      Core_Application_App__set_FileDownloadLogger(uVar1,uVar1);
		      **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar1;
		      param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    uVar1 = unnamed_function_1417
		                      (Core_Events_Scopes_AppScope_AverageFpsCalculatedEventArgs_TypeInfo);
		    Core_Events_Scopes_AppScope_AverageFpsCalculatedEventArgs__get_FPS
		              (uVar1,param2_00,param3_00,param2,0);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006E8B RID: 28299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E8B")]
		[Address(RVA = "0xB92A", Offset = "0xB92A", VA = "0xB92A")]
		private void FPSStatsOnAverageFpsCalculatedEvent(float fps)
		{
		/* --- GHIDRA: FPSStatsOnAverageFpsCalculatedEvent ---
		void Core_Application_App__FPSStatsOnAverageFpsCalculatedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param2_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a7fc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_UiScope_ToolTipShownEventArgs_TypeInfo);
		    DAT_ram_00a5a7fc = '\x01';
		  }
		  if (DAT_ram_00a5a7ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		    DAT_ram_00a5a7ed = '\x01';
		  }
		  iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  if (iVar2 == 0) {
		    uVar1 = unnamed_function_1417(Core_Application_App_TypeInfo);
		    Core_Application_App__set_FileDownloadLogger(uVar1,uVar1);
		    **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar1;
		    iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  }
		  iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x44) + 0x10);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a5a7ed == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		      DAT_ram_00a5a7ed = '\x01';
		    }
		    param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    if (param2_00 == 0) {
		      uVar1 = unnamed_function_1417(Core_Application_App_TypeInfo);
		      Core_Application_App__set_FileDownloadLogger(uVar1,uVar1);
		      **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar1;
		      param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    uVar1 = unnamed_function_1417(Core_Events_Scopes_UiScope_ToolTipShownEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(uVar1,param2_00,param3_00,param2,0)
		    ;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006E8C RID: 28300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E8C")]
		[Address(RVA = "0xB92B", Offset = "0xB92B", VA = "0xB92B")]
		private void ToolTipControllerOnShownEvent(IToolTipSource data)
		{
		/* --- GHIDRA: ToolTipControllerOnShownEvent ---
		void Core_Application_App__ToolTipControllerOnShownEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param2_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a7fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_UiScope_WindowOpenedEventArgs_TypeInfo);
		    DAT_ram_00a5a7fd = '\x01';
		  }
		  if (DAT_ram_00a5a7ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		    DAT_ram_00a5a7ed = '\x01';
		  }
		  iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  if (iVar2 == 0) {
		    uVar1 = unnamed_function_1417(Core_Application_App_TypeInfo);
		    Core_Application_App__set_FileDownloadLogger(uVar1,uVar1);
		    **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar1;
		    iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  }
		  iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x44) + 8);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a5a7ed == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		      DAT_ram_00a5a7ed = '\x01';
		    }
		    param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    if (param2_00 == 0) {
		      uVar1 = unnamed_function_1417(Core_Application_App_TypeInfo);
		      Core_Application_App__set_FileDownloadLogger(uVar1,uVar1);
		      **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar1;
		      param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    uVar1 = unnamed_function_1417(Core_Events_Scopes_UiScope_WindowOpenedEventArgs_TypeInfo);
		    Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		              (uVar1,param2_00,param3_00,param2,param3,0);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006E8D RID: 28301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E8D")]
		[Address(RVA = "0xB92C", Offset = "0xB92C", VA = "0xB92C")]
		private void PopupControllerOnWindowOpenedEvent(string windowId, BaseWindowArgs windowArgs)
		{
		/* --- GHIDRA: PopupControllerOnWindowOpenedEvent ---
		void Core_Application_App__PopupControllerOnWindowOpenedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param2_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a7fe == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_UiScope_WindowClosedEventArgs_TypeInfo);
		    DAT_ram_00a5a7fe = '\x01';
		  }
		  if (DAT_ram_00a5a7ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		    DAT_ram_00a5a7ed = '\x01';
		  }
		  iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  if (iVar2 == 0) {
		    uVar1 = unnamed_function_1417(Core_Application_App_TypeInfo);
		    Core_Application_App__set_FileDownloadLogger(uVar1,uVar1);
		    **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar1;
		    iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  }
		  iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x44) + 0xc);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a5a7ed == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		      DAT_ram_00a5a7ed = '\x01';
		    }
		    param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    if (param2_00 == 0) {
		      uVar1 = unnamed_function_1417(Core_Application_App_TypeInfo);
		      Core_Application_App__set_FileDownloadLogger(uVar1,uVar1);
		      **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar1;
		      param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    uVar1 = unnamed_function_1417(Core_Events_Scopes_UiScope_WindowClosedEventArgs_TypeInfo);
		    Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		              (uVar1,param2_00,param3_00,param2,param3,0);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

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

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_AppQuitEvent ---
		void Core_Application_App__add_AppQuitEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5a7ef == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5a7ef = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 8,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_AppQuitEvent ---
		void Core_Application_App__remove_AppQuitEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a7f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IApp__TypeInfo);
		    DAT_ram_00a5a7f0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IApp__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IApp__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Application_App__add_InitCompleteEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a7f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IApp__TypeInfo);
		    DAT_ram_00a5a7f1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IApp__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IApp__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_Platform ---
		undefined4 Core_Application_App__get_Platform(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int *piVar3;
		  int *param2_00;
		  int iVar4;
		  undefined4 *puVar5;
		  undefined4 uVar6;
		  int iVar7;
		  uint *puVar8;
		  undefined8 param3;
		  undefined4 param3_00;
		  int param3_01;
		  uint uVar9;
		  int local_18;
		  int **local_14;
		  int local_10;
		  int **local_c;
		  int *local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5760b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Convert_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LogTargetContentVo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LogTargetContentVo__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_IO_MemoryStream_TypeInfo);
		    Mono_Security_ASN1__get_Item(&ICSharpCode_SharpZipLib_Zip_ZipEntry_TypeInfo);
		    Mono_Security_ASN1__get_Item(&ICSharpCode_SharpZipLib_Zip_ZipOutputStream_TypeInfo);
		    DAT_ram_00a5760b = '\x01';
		  }
		  local_8 = (int *)0x0;
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  iVar2 = OKG_Logs_Debug___cctor(0);
		  piVar3 = (int *)unnamed_function_1417(System_IO_MemoryStream_TypeInfo);
		  ICSharpCode_SharpZipLib_Zip_ZipException___ctor(piVar3,0);
		  DAT_ram_009d3e38 = 0;
		  local_10 = 0;
		  local_c = &local_4;
		  local_4 = piVar3;
		  param2_00 = (int *)import::env::invoke_ii
		                               (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                ICSharpCode_SharpZipLib_Zip_ZipOutputStream_TypeInfo);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80db79dc:
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar2 = global_1;
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x328,param2_00,piVar3,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80db79dc;
		    param3_01 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_18 = 0;
		    local_14 = &local_8;
		    local_8 = param2_00;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x329,param2_00,3,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80db7713:
		      iVar2 = global_1;
		      iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar2 == iVar7) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(uVar6);
		        iVar2 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          if (local_8 != (int *)0x0) goto code_r0x80db7768;
		          goto code_r0x80db783c;
		        }
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar2 = global_1;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x330,&local_18);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) goto code_r0x80db7b01;
		    }
		    else {
		      iVar7 = *(int *)(iVar2 + 0xc);
		      if (0 < iVar7) {
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar4 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22a,iVar2,param3_01
		                             ,Method_System_Collections_Generic_List_LogTargetContentVo__get_Item__)
		          ;
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80db7713;
		          }
		          param3_00 = *(undefined4 *)(iVar4 + 8);
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::invoke_ii
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                             ICSharpCode_SharpZipLib_Zip_ZipEntry_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80db76b1:
		            DAT_ram_009d3e38 = 0;
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80db7713;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x32a,uVar6,param3_00,0);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80db76b1;
		          if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       System_DateTime_TypeInfo);
		            iVar1 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar1 == 1) {
		              uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80db7713;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          param3 = unnamed_function_184055
		                             (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x32b,0);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80db7713;
		          }
		          DAT_ram_009d3e38 = 0;
		          unnamed_function_184058
		                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x32c,uVar6,param3,0);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80db7713;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x32d,local_8,uVar6,0);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80db7713;
		          }
		          DAT_ram_009d3e38 = 0;
		          piVar3 = (int *)import::env::invoke_ii
		                                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x32e,0);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80db7713;
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar4 = import::env::invoke_iiii
		                            (*(undefined4 *)(*piVar3 + 0x158),piVar3,*(undefined4 *)(iVar4 + 0xc),
		                             *(undefined4 *)(*piVar3 + 0x15c));
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80db7713;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiiii
		                    (*(undefined4 *)(*local_8 + 0x1e8),local_8,iVar4,0,*(undefined4 *)(iVar4 + 0xc),
		                     *(undefined4 *)(*local_8 + 0x1ec));
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80db7713;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x32f,local_8,0)
		          ;
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80db7713;
		          }
		          param3_01 = param3_01 + 1;
		        } while (param3_01 != iVar7);
		      }
		      iVar2 = 0;
		      *(undefined1 *)(local_8 + 5) = 0;
		code_r0x80db7768:
		      piVar3 = local_8;
		      uVar9 = 0;
		      iVar7 = *local_8;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		            puVar5 = (undefined4 *)
		                     (iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80db7800;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar5 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                          System_IDisposable_TypeInfo,0);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x80db7800:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(*puVar5,piVar3,puVar5[1]);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x80db783c:
		          if (iVar2 == 0) {
		            DAT_ram_009d3e38 = 0;
		            unnamed_function_184058
		                      (*(undefined4 *)(*local_4 + 0x128),local_4,0,*(undefined4 *)(*local_4 + 300));
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 == 1) {
		              uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar2 = global_1;
		              goto code_r0x80db79eb;
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar6 = import::env::invoke_iii
		                              (*(undefined4 *)(*local_4 + 0x218),local_4,
		                               *(undefined4 *)(*local_4 + 0x21c));
		            if (DAT_ram_009d3e38 == 1) {
		code_r0x80db79d2:
		              DAT_ram_009d3e38 = 0;
		              uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar2 = global_1;
		            }
		            else {
		              iVar2 = 0;
		              if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vi
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                           System_Convert_TypeInfo);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x80db79d2;
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar6 = import::env::invoke_iii
		                                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x187,uVar6,0);
		              iVar7 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar7 != 1) goto code_r0x80db7a36;
		              uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar2 = global_1;
		            }
		            goto code_r0x80db79eb;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar2);
		          if (DAT_ram_009d3e38 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar2 = global_1;
		    }
		  }
		code_r0x80db79eb:
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar6);
		    iVar2 = *piVar3;
		    uVar6 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_10 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x80db7a36:
		      piVar3 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar9 = 0;
		        iVar7 = *local_4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		              puVar8 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80db7aae;
		            }
		            uVar9 = uVar9 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		        }
		        puVar8 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80db7aae:
		        (**(code **)((ulonglong)*puVar8 * 4))(piVar3,puVar8[1]);
		      }
		      if (iVar2 == 0) {
		        return uVar6;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar6 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x331,&local_10);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    import::env::__resumeException(uVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x80db7b01:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_ContextMenuController ---
		undefined4 Core_Application_App__get_ContextMenuController(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x18) + 0x38);
		}
		*/


		/* --- GHIDRA: get_PopupController ---
		undefined4 Core_Application_App__get_PopupController(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a639e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_BaseWindow__get_Count__);
		    DAT_ram_00a639e1 = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(param1 + 0x2c) + 0xc);
		}
		*/


		/* --- GHIDRA: set_Auth ---
		undefined4 Core_Application_App__set_Auth(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a7f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_GameRestart_TypeInfo);
		    DAT_ram_00a5a7f2 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Core_Gameplay_GameRestart_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,param1,0);
		  return param1_00;
		}
		*/


		/* --- GHIDRA: get_GameRestart ---
		undefined4 Core_Application_App__get_GameRestart(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a7f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_GameResolver_TypeInfo);
		    DAT_ram_00a5a7f3 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Core_Gameplay_GameResolver_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,param1,0);
		  return param1_00;
		}
		*/


		/* --- GHIDRA: get_ToastController ---
		void Core_Application_App__get_ToastController
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = UI_Toast_ToastController_ToastData__Create(param2,param3,param1);
		  UI_Toast_ToastController__OnReleaseToast(param1,param2_00,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_PlatformSigninManager ---
		undefined4 Core_Application_App__set_PlatformSigninManager(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x18) + 0x40);
		}
		*/


		/* --- GHIDRA: set_FileDownloadLogger ---
		void Core_Application_App__set_FileDownloadLogger(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a7f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Heavens_External_AppHolder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_Android_DeviceIDProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Log_Files_FileDownloadLogger_TypeInfo);
		    DAT_ram_00a5a7f4 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Log_Files_FileDownloadLogger_TypeInfo);
		  Core_Log_Files_FileDownloadLogger__Dispose(uVar1,1,0);
		  *(undefined4 *)(param1 + 0x60) = uVar1;
		  uVar1 = unnamed_function_1417(OKG_Heavens_External_AppHolder_TypeInfo);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  uVar1 = unnamed_function_1417(Core_Analytics_Service_Android_DeviceIDProvider_TypeInfo);
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  return;
		}
		*/

}
