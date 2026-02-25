using System;
using Il2CppDummyDll;
using Protocol.Craft;
using UI.Filters;

namespace Gameplay.Craft.Controller.Filters
{
	// Token: 0x020008D7 RID: 2263
	[Token(Token = "0x20008D7")]
	public interface ICraftSlotFilter
	{
		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x0600354B RID: 13643
		// (set) Token: 0x0600354C RID: 13644
		[Token(Token = "0x17000A82")]
		FilterInfo FilterInfo { [Token(Token = "0x600354B")] get; [Token(Token = "0x600354C")] set; }

		// Token: 0x0600354D RID: 13645
		[Token(Token = "0x600354D")]
		bool Filter(UserCraftSlotInfo craftSlotInfo);
	}
}
