using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x02000276 RID: 630
	[Token(Token = "0x2000276")]
	public class PopupController : MonoBehaviour
	{
		// Token: 0x140000F8 RID: 248
		// (add) Token: 0x06000F10 RID: 3856 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000F11 RID: 3857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F8")]
		public event PopupController.StateChanged OnChangeStateEvent
		{
			[Token(Token = "0x6000F10")]
			[Address(RVA = "0x614F", Offset = "0x614F", VA = "0x614F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000F11")]
			[Address(RVA = "0x6150", Offset = "0x6150", VA = "0x6150")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000F9 RID: 249
		// (add) Token: 0x06000F12 RID: 3858 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000F13 RID: 3859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F9")]
		public event Action<string, BaseWindowArgs> OnWindowOpenedEvent
		{
			[Token(Token = "0x6000F12")]
			[Address(RVA = "0x6151", Offset = "0x6151", VA = "0x6151")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000F13")]
			[Address(RVA = "0x6152", Offset = "0x6152", VA = "0x6152")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000FA RID: 250
		// (add) Token: 0x06000F14 RID: 3860 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000F15 RID: 3861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000FA")]
		public event Action<string, WindowCloseReason> OnWindowClosedEvent
		{
			[Token(Token = "0x6000F14")]
			[Address(RVA = "0x6153", Offset = "0x6153", VA = "0x6153")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000F15")]
			[Address(RVA = "0x6154", Offset = "0x6154", VA = "0x6154")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000F17 RID: 3863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000218")]
		public BaseWindow TopWindow
		{
			[Token(Token = "0x6000F16")]
			[Address(RVA = "0x6155", Offset = "0x6155", VA = "0x6155")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F17")]
			[Address(RVA = "0x6156", Offset = "0x6156", VA = "0x6156")]
			private set
			{
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x17000219")]
		public int OpenedWindowsCount
		{
			[Token(Token = "0x6000F18")]
			[Address(RVA = "0x4444", Offset = "0x4444", VA = "0x4444")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F19")]
		public T Show<T>(string windowId, BaseWindowArgs args) where T : BaseWindow
		{
			return null;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F1A")]
		[Address(RVA = "0x6157", Offset = "0x6157", VA = "0x6157")]
		public BaseWindow Show(string windowId, BaseWindowArgs args, [Optional] Type windowTargetType)
		{
			return null;
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1B")]
		[Address(RVA = "0x6158", Offset = "0x6158", VA = "0x6158")]
		public void Close(BaseWindow window, WindowCloseReason windowCloseReason)
		{
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1C")]
		public void Close<T>(WindowCloseReason windowCloseReason)
		{
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1D")]
		[Address(RVA = "0x2232", Offset = "0x2232", VA = "0x2232")]
		public void CloseAllForce()
		{
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1E")]
		[Address(RVA = "0x6159", Offset = "0x6159", VA = "0x6159")]
		public void CloseAll(WindowCloseReason windowCloseReason)
		{
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F1F")]
		[Address(RVA = "0x615A", Offset = "0x615A", VA = "0x615A")]
		public BaseWindow BringWindowToFront(BaseWindow window)
		{
			return null;
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x6000F20")]
		[Address(RVA = "0x615B", Offset = "0x615B", VA = "0x615B")]
		public int GetVisibleFullscreenWindowsCount()
		{
			return 0;
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F21")]
		[Address(RVA = "0x615C", Offset = "0x615C", VA = "0x615C")]
		private void ValidateVisibility(out int visibleFullscreenWndCount)
		{
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x6000F22")]
		public bool HasOpenWindow<T>() where T : BaseWindow
		{
			return default(bool);
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x6000F23")]
		[Address(RVA = "0x615D", Offset = "0x615D", VA = "0x615D")]
		public bool TryGetLayer(LayerId id, out Layer layer)
		{
			return default(bool);
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F24")]
		public T[] GetWindows<T>() where T : BaseWindow
		{
			return null;
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F25")]
		public T GetLastWindow<T>() where T : BaseWindow
		{
			return null;
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x6000F26")]
		[Address(RVA = "0x615E", Offset = "0x615E", VA = "0x615E")]
		public bool TryGetLastWindow(out BaseWindow window)
		{
			return default(bool);
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F27")]
		[Address(RVA = "0x615F", Offset = "0x615F", VA = "0x615F")]
		public void SetVisibleAllWindows(bool value)
		{
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F28")]
		[Address(RVA = "0x6160", Offset = "0x6160", VA = "0x6160")]
		public void SetVisible(BaseWindow openedWindow, bool value)
		{
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x6161", Offset = "0x6161", VA = "0x6161")]
		private void OnWindowClose(BaseWindow baseWindow, WindowCloseReason closeReason)
		{
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x6162", Offset = "0x6162", VA = "0x6162")]
		private void OnWindowBringToFront(BaseWindow baseWindow)
		{
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0x6163", Offset = "0x6163", VA = "0x6163")]
		private void OnUpdateBgInWindow(BaseWindow baseWindow)
		{
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0x6164", Offset = "0x6164", VA = "0x6164")]
		private void OnVisibleChange(BaseWindow baseWindow, bool active)
		{
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2D")]
		[Address(RVA = "0x6165", Offset = "0x6165", VA = "0x6165")]
		private void UpdateBg()
		{
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2E")]
		[Address(RVA = "0x6166", Offset = "0x6166", VA = "0x6166")]
		public PopupController()
		{
		}

		// Token: 0x04000795 RID: 1941
		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RectTransform _windowBG;

		// Token: 0x04000796 RID: 1942
		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Layer _defaultLayer;

		// Token: 0x04000797 RID: 1943
		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Layer[] _layers;

		// Token: 0x0400079B RID: 1947
		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly IInstantiator _instantiator;

		// Token: 0x0400079C RID: 1948
		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private readonly LinkedList<BaseWindow> _openedWindows;

		// Token: 0x0400079D RID: 1949
		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BaseWindow _topWindow;

		// Token: 0x0400079E RID: 1950
		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private readonly Dictionary<LayerId, LinkedList<BaseWindow>> _windowsByLayers;

		// Token: 0x02000277 RID: 631
		// (Invoke) Token: 0x06000F30 RID: 3888
		[Token(Token = "0x2000277")]
		public delegate void StateChanged(int visibleFullscreenWndCount);
	}
}
