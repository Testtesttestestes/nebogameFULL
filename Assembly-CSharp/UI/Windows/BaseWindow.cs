using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UI.UIController;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x0200026A RID: 618
	[Token(Token = "0x200026A")]
	public abstract class BaseWindow : MonoBehaviour, IManagedWindow, IDisposable
	{
		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x17000202")]
		public ResourceBarColor ResourceBarColor
		{
			[Token(Token = "0x6000ECD")]
			[Address(RVA = "0x612A", Offset = "0x612A", VA = "0x612A")]
			get
			{
				return ResourceBarColor.Default;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x17000203")]
		public bool IsActiveResourceBar
		{
			[Token(Token = "0x6000ECE")]
			[Address(RVA = "0x612B", Offset = "0x612B", VA = "0x612B")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x140000F7 RID: 247
		// (add) Token: 0x06000ECF RID: 3791 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000ED0 RID: 3792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F7")]
		public event Action onClose
		{
			[Token(Token = "0x6000ECF")]
			[Address(RVA = "0x612C", Offset = "0x612C", VA = "0x612C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000ED0")]
			[Address(RVA = "0x612D", Offset = "0x612D", VA = "0x612D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000ED1 RID: 3793
		[Token(Token = "0x17000204")]
		public abstract string WindowId { [Token(Token = "0x6000ED1")] get; }

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x00004308 File Offset: 0x00002508
		// (set) Token: 0x06000ED3 RID: 3795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000205")]
		private bool HideBG
		{
			[Token(Token = "0x6000ED2")]
			[Address(RVA = "0x612E", Offset = "0x612E", VA = "0x612E", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ED3")]
			[Address(RVA = "0x612F", Offset = "0x612F", VA = "0x612F", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x17000206")]
		private bool IsFullscreenWindow
		{
			[Token(Token = "0x6000ED4")]
			[Address(RVA = "0x6130", Offset = "0x6130", VA = "0x6130", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x00004338 File Offset: 0x00002538
		// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000207")]
		private bool HideBG
		{
			[Token(Token = "0x6000ED5")]
			[Address(RVA = "0x6131", Offset = "0x6131", VA = "0x6131")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ED6")]
			[Address(RVA = "0x6132", Offset = "0x6132", VA = "0x6132")]
			set
			{
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x17000208")]
		public virtual bool IsFullscreenWindow
		{
			[Token(Token = "0x6000ED7")]
			[Address(RVA = "0x6133", Offset = "0x6133", VA = "0x6133", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0x6134", Offset = "0x6134", VA = "0x6134", Slot = "8")]
		private void Init(Action<BaseWindow, WindowCloseReason> onSelfClose, Action<BaseWindow> onSelfBringToFront, Action<BaseWindow> onSelfChangeBgState, Action<BaseWindow, bool> onSelfVisibleChange)
		{
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0x6135", Offset = "0x6135", VA = "0x6135", Slot = "9")]
		private void Show(BaseWindowArgs args)
		{
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x6136", Offset = "0x6136", VA = "0x6136", Slot = "10")]
		private void FocusChanged(bool focused)
		{
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x6137", Offset = "0x6137", VA = "0x6137", Slot = "11")]
		private void VisibleChanged(bool focused)
		{
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EDD RID: 3805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000209")]
		public BaseWindowArgs WindowArgs
		{
			[Token(Token = "0x6000EDC")]
			[Address(RVA = "0x6138", Offset = "0x6138", VA = "0x6138", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EDD")]
			[Address(RVA = "0x6139", Offset = "0x6139", VA = "0x6139")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDE")]
		[Address(RVA = "0x613A", Offset = "0x613A", VA = "0x613A")]
		public void BringToFront()
		{
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0x613B", Offset = "0x613B", VA = "0x613B")]
		public void VisibleChange(bool active)
		{
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE0")]
		[Address(RVA = "0x1AE3", Offset = "0x1AE3", VA = "0x1AE3", Slot = "16")]
		public void Close(WindowCloseReason windowCloseReason)
		{
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE1")]
		[Address(RVA = "0x613C", Offset = "0x613C", VA = "0x613C", Slot = "13")]
		private void Dispose()
		{
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x6000EE2")]
		[Address(RVA = "0x613D", Offset = "0x613D", VA = "0x613D", Slot = "17")]
		public virtual bool CheckForClose()
		{
			return default(bool);
		}

		// Token: 0x06000EE3 RID: 3811
		[Token(Token = "0x6000EE3")]
		protected abstract void OnShow(BaseWindowArgs args);

		// Token: 0x06000EE4 RID: 3812
		[Token(Token = "0x6000EE4")]
		protected abstract void OnClose();

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0x613E", Offset = "0x613E", VA = "0x613E", Slot = "20")]
		protected virtual void OnFocusChanged(bool focused)
		{
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x613F", Offset = "0x613F", VA = "0x613F", Slot = "21")]
		protected virtual void OnVisibleChanged(bool active)
		{
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE7")]
		[Address(RVA = "0x6140", Offset = "0x6140", VA = "0x6140")]
		protected BaseWindow()
		{
		}

		// Token: 0x0400077A RID: 1914
		[Token(Token = "0x400077A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _hideBG;

		// Token: 0x0400077B RID: 1915
		[Token(Token = "0x400077B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ResourceBarColor _resourceBarColor;

		// Token: 0x0400077C RID: 1916
		[Token(Token = "0x400077C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _isActiveResourceBar;

		// Token: 0x0400077E RID: 1918
		[Token(Token = "0x400077E")]
		[FieldOffset(Offset = "0x20")]
		private Action<BaseWindow, WindowCloseReason> onSelfClose;

		// Token: 0x0400077F RID: 1919
		[Token(Token = "0x400077F")]
		[FieldOffset(Offset = "0x24")]
		private Action<BaseWindow> onSelfBringToFront;

		// Token: 0x04000780 RID: 1920
		[Token(Token = "0x4000780")]
		[FieldOffset(Offset = "0x28")]
		private Action<BaseWindow> onSelfChangeBgState;

		// Token: 0x04000781 RID: 1921
		[Token(Token = "0x4000781")]
		[FieldOffset(Offset = "0x2C")]
		private Action<BaseWindow, bool> onSelfVisibleChange;
	}
}
