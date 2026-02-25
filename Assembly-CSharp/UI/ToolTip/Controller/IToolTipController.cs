using System;
using Il2CppDummyDll;

namespace UI.ToolTip.Controller
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	public interface IToolTipController
	{
		// Token: 0x140000D5 RID: 213
		// (add) Token: 0x06000A22 RID: 2594
		// (remove) Token: 0x06000A23 RID: 2595
		[Token(Token = "0x140000D5")]
		event Action<IToolTipSource> ShownEvent;

		// Token: 0x06000A24 RID: 2596
		[Token(Token = "0x6000A24")]
		void Show(IToolTipSource source);

		// Token: 0x06000A25 RID: 2597
		[Token(Token = "0x6000A25")]
		void Hide(IToolTipSource source);
	}
}
