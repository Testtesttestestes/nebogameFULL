using System;
using Core.Data;
using Il2CppDummyDll;

namespace UI.UserContextMenu
{
	// Token: 0x02000129 RID: 297
	[Token(Token = "0x2000129")]
	public interface IUserMenuContext
	{
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000924 RID: 2340
		// (set) Token: 0x06000925 RID: 2341
		[Token(Token = "0x1700012A")]
		UserData User { [Token(Token = "0x6000924")] get; [Token(Token = "0x6000925")] set; }
	}
}
