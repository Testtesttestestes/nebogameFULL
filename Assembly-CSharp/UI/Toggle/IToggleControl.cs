using System;
using Il2CppDummyDll;

namespace UI.Toggle
{
	// Token: 0x0200016F RID: 367
	[Token(Token = "0x200016F")]
	public interface IToggleControl
	{
		// Token: 0x140000D7 RID: 215
		// (add) Token: 0x06000A41 RID: 2625
		// (remove) Token: 0x06000A42 RID: 2626
		[Token(Token = "0x140000D7")]
		event Action ChangedEvent;

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000A43 RID: 2627
		// (set) Token: 0x06000A44 RID: 2628
		[Token(Token = "0x17000150")]
		bool IsEnabled { [Token(Token = "0x6000A43")] get; [Token(Token = "0x6000A44")] set; }
	}
}
