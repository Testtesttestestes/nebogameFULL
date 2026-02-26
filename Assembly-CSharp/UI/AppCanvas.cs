using System;
using System.Runtime.CompilerServices;
using Core.Dev;
using Gameplay.ResourceBar.View;
using Gameplay.Sound.View;
using Il2CppDummyDll;
using TMPro;
using UI.ConfirmationMessage;
using UI.ContextMenu;
using UI.Informer;
using UI.Toast;
using UI.ToolTip.Controller;
using UI.Windows;
using UnityEngine;
using Utils.Fps;

namespace UI
{
	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000ED")]
	public class AppCanvas : MonoBehaviour
	{
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F0")]
		public ResourceBarView ResourceBar
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x5BB8", Offset = "0x5BB8", VA = "0x5BB8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F1")]
		public DevMenuUnlocker DevMenuUnlocker
		{
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x5BB9", Offset = "0x5BB9", VA = "0x5BB9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F2")]
		public Transform TopLayer
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x5BBA", Offset = "0x5BBA", VA = "0x5BBA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F3")]
		public InformerView InformerView
		{
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x5BBB", Offset = "0x5BBB", VA = "0x5BBB")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F4")]
		public FpsStats FPSStats
		{
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x5BBC", Offset = "0x5BBC", VA = "0x5BBC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F5")]
		public TextMeshProUGUI VersionLabel
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x5BBD", Offset = "0x5BBD", VA = "0x5BBD")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F6")]
		public ContextMenuController ContextMenuController
		{
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x5BBE", Offset = "0x5BBE", VA = "0x5BBE")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F7")]
		public PopupController PopupController
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x5BBF", Offset = "0x5BBF", VA = "0x5BBF")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F8")]
		public ToastController ToastController
		{
			[Token(Token = "0x6000802")]
			[Address(RVA = "0x5BC0", Offset = "0x5BC0", VA = "0x5BC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F9")]
		public ConfirmationMessageController ConfirmationMessageController
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x5BC1", Offset = "0x5BC1", VA = "0x5BC1")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FA")]
		public IToolTipController ToolTipController
		{
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x5BC2", Offset = "0x5BC2", VA = "0x5BC2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x5BC3", Offset = "0x5BC3", VA = "0x5BC3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000FB")]
		public GameAudioSource AudioSource
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x5BC4", Offset = "0x5BC4", VA = "0x5BC4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x5BC5", Offset = "0x5BC5", VA = "0x5BC5")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_AppCanvas__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5b867 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_AppCanvas_DevMenuUnlockerOnDevMenuUnlockedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_UI_AppCanvas_ShowDevMenu__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10750);
		    DAT_ram_00a5b867 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10750,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar2,1,uVar1,0);
		  uVar1 = *(undefined4 *)(param1 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_UI_AppCanvas_DevMenuUnlockerOnDevMenuUnlockedEvent__,0);
		  Core_Dev_DevMenuUnlocker__add_DevMenuUnlockedEvent(uVar1,uVar2,0);
		  uVar1 = *(undefined4 *)(param1 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener(uVar2,param1,Method_UI_AppCanvas_ShowDevMenu__,0);
		  Core_Dev_DevMenuUnlocker__remove_DevMenuUnlockedEvent(uVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x5BC6", Offset = "0x5BC6", VA = "0x5BC6")]
		private void DevMenuUnlockerOnDevMenuUnlockedEvent()
		{
		/* --- GHIDRA: DevMenuUnlockerOnDevMenuUnlockedEvent ---
		void UI_AppCanvas__DevMenuUnlockerOnDevMenuUnlockedEvent(int param1,undefined4 param2)
		
		{
		  Core_Dev_DevMenuUnlocker__Validate(*(undefined4 *)(param1 + 0x24),0);
		  return;
		}
		*/

		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x5BC7", Offset = "0x5BC7", VA = "0x5BC7")]
		private void ShowDevMenu()
		{
		/* --- GHIDRA: ShowDevMenu ---
		void UI_AppCanvas__ShowDevMenu(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5b868 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_AppCanvas_DevMenuUnlockerOnDevMenuUnlockedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_UI_AppCanvas_ShowDevMenu__);
		    DAT_ram_00a5b868 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_UI_AppCanvas_DevMenuUnlockerOnDevMenuUnlockedEvent__,0);
		  Core_Dev_DevMenuUnlocker__add_DevMenuUnlockedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener(uVar1,param1,Method_UI_AppCanvas_ShowDevMenu__,0);
		  Core_Dev_DevMenuUnlocker__add_ClickedEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x5BC8", Offset = "0x5BC8", VA = "0x5BC8")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x5BC9", Offset = "0x5BC9", VA = "0x5BC9")]
		public AppCanvas()
		{
		}

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ContextMenuController _contextMenuController;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private PopupController _popupController;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ToastController _toastController;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ConfirmationMessageController _confirmationMessageController;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _versionLabel;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private DevMenuUnlocker _devMenuUnlocker;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FpsStats _fpsStats;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Canvas _toolCanvas;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameAudioSource _audioSource;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private InformerView _informerView;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _topLayer;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ResourceBarView _resourceBar;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_AudioSource ---
		void UI_AppCanvas__get_AudioSource(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b866 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_AppCanvas_DevMenuUnlockerOnDevMenuUnlockedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_Controller_WebGL_ToolTipController_TypeInfo);
		    DAT_ram_00a5b866 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x2c);
		  uVar1 = func_ii_5677(param1_00,Method_UnityEngine_Component_GetComponent_RectTransform___);
		  uVar2 = unnamed_function_1417(UI_ToolTip_Controller_WebGL_ToolTipController_TypeInfo);
		  local_10 = 0;
		  local_8 = 0;
		  UI_ToolTip_Controller_BaseToolTipController__UpdateToolTipPositionCoroutine_d__22__System_Collections_IEnumerator_get_Current
		            (uVar2,param1_00,uVar1,&local_10,0);
		  *(undefined4 *)(param1 + 0x40) = uVar2;
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  UnityEngine_Object__FindObjectsByType(uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_UI_AppCanvas_DevMenuUnlockerOnDevMenuUnlockedEvent__,0);
		  Core_Dev_DevMenuShowConsole___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

}
