using System;
using Il2CppDummyDll;

namespace UI.Windows
{
	// Token: 0x02000272 RID: 626
	[Token(Token = "0x2000272")]
	public interface IManagedWindow : IDisposable
	{
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000F02 RID: 3842
		// (set) Token: 0x06000F03 RID: 3843
		[Token(Token = "0x17000211")]
		bool HideBG { [Token(Token = "0x6000F02")] get; [Token(Token = "0x6000F03")] set; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000F04 RID: 3844
		[Token(Token = "0x17000212")]
		string WindowId { [Token(Token = "0x6000F04")] get; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000F05 RID: 3845
		[Token(Token = "0x17000213")]
		bool IsFullscreenWindow { [Token(Token = "0x6000F05")] get; }

		// Token: 0x06000F06 RID: 3846
		[Token(Token = "0x6000F06")]
		void Init(Action<BaseWindow, WindowCloseReason> onSelfClose, Action<BaseWindow> onSelfBringToFront, Action<BaseWindow> onSelfChangeBgState, Action<BaseWindow, bool> onSelfVisibleChange);

		// Token: 0x06000F07 RID: 3847
		[Token(Token = "0x6000F07")]
		void Show(BaseWindowArgs args);

		// Token: 0x06000F08 RID: 3848
		[Token(Token = "0x6000F08")]
		void FocusChanged(bool focused);

		// Token: 0x06000F09 RID: 3849
		[Token(Token = "0x6000F09")]
		void VisibleChanged(bool focused);

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000F0A RID: 3850
		[Token(Token = "0x17000214")]
		BaseWindowArgs WindowArgs { [Token(Token = "0x6000F0A")] get; }
	}
}
