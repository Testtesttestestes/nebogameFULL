using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Tabs
{
	// Token: 0x02000178 RID: 376
	[Token(Token = "0x2000178")]
	public interface ITabBarItemView
	{
		// Token: 0x140000DB RID: 219
		// (add) Token: 0x06000A8D RID: 2701
		// (remove) Token: 0x06000A8E RID: 2702
		[Token(Token = "0x140000DB")]
		event Action<TabBarItemData> SelectEvent;

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000A8F RID: 2703
		// (set) Token: 0x06000A90 RID: 2704
		[Token(Token = "0x17000160")]
		bool Selected { [Token(Token = "0x6000A8F")] get; [Token(Token = "0x6000A90")] set; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000A91 RID: 2705
		// (set) Token: 0x06000A92 RID: 2706
		[Token(Token = "0x17000161")]
		TabBarItemData Data { [Token(Token = "0x6000A91")] get; [Token(Token = "0x6000A92")] set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000A93 RID: 2707
		[Token(Token = "0x17000162")]
		GameObject GameObject { [Token(Token = "0x6000A93")] get; }
	}
}
